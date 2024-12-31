using CommonLayer.Entities.Projects;
using Dapper;
using DataAccessLayer.DbConnection;
using DataAccessLayer.Repositories.InterfacesRepositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ProjectsRepositories : IProjectsRepositories
    {
        private readonly ISqlDataAccess _dbConnection;

        public ProjectsRepositories(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Projects> GetAllProjects()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT r.idProject, r.codeProject ,u.UserAccount, r.nameProject, r.descriptionProject, st.statusproject, r.dateInit, r.dateEnd, r.dateRegistration FROM RequestProjectClient r
                                LEFT JOIN Clients c on c.idCliente = r.idClient
                                LEFT JOIN Users u on u.idUser = c.idUser
                                LEFT JOIN statusProject st on st.idStatusProject = r.idStatusProject";

                return connection.Query<Projects>(query);
            }
        }

        public IEnumerable<StatusProjects> GetStatusProject()
        {
            using( var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT * FROM statusProject";

                return connection.Query<StatusProjects>(query);
            }
        }

        public void UpdateTaskEmployee(int idTask, byte[] file, int idStatusTask)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE taskProjects SET
                                 fileTask = @file,
                                 idStatusTask = @idStatusTask
                                 WHERE idTask = @idTask";

                connection.Query(query, new { idTask, file, idStatusTask });
            }
        }

        public IEnumerable<Projects> GetRequestProjectsByStatus(string statusProject)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT r.idProject, r.codeProject ,u.UserAccount, r.nameProject, r.descriptionProject, st.statusproject, r.dateInit, r.dateEnd, r.dateRegistration FROM RequestProjectClient r
                                LEFT JOIN Clients c on c.idCliente = r.idClient
                                LEFT JOIN Users u on u.idUser = c.idUser
                                LEFT JOIN statusProject st on st.idStatusProject = r.idStatusProject
                                WHERE st.statusProject = @statusProject";

                return connection.Query<Projects>(query, new { statusProject });
            }
        }

        public IEnumerable<TaskEmployees> GetTaskEmployees()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT tp.idTask, tp.idEmployee , tp.codeProject, u.UserAccount, tp.nameTask, tp.descriptionTask, se.statusTask, tp.dateEnd FROM taskProjects tp
                                LEFT JOIN employee e on e.idEmployee = tp.idEmployee
                                LEFT JOIN Users u on u.idUser = e.idEmployee
                                INNER JOIN taskEmployeesStatus se on se.idStatusTask = tp.idStatusTask
                                ";

                return connection.Query<TaskEmployees>(query);
            }
        }

        public void StatusProject(string codeProject, int idStatusProject)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE RequestProjectClient SET 
                                idStatusProject = @idStatusProject
                                WHERE codeProject = @codeProject";

                connection.Query<Projects>(query, new { codeProject , idStatusProject });
            }
        }

        public void UpdateDates(string codeProject, DateTime? dateInit = null , DateTime? dateEnd = null)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                var updates = new List<String>();

                if (dateInit.HasValue)
                {
                    updates.Add("dateInit = @dateInit");
                }
                if (dateEnd.HasValue)
                {
                    updates.Add("dateEnd = @dateEnd");
                }

                string query = $@"UPDATE RequestProjectClient SET
                                 {string.Join(", ", updates)}
                                  WHERE codeProject = @codeProject";

                connection.Query<Projects>(query, new { codeProject, dateInit, dateEnd });
            }
        }

        public void SendProjects(string codeProject, byte[] file)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE RequestProjectClient SET  
                                 [file] = @file
                                 WHERE codeProject = @codeProject";

                connection.Query<Projects>(query, new { codeProject ,file });
            }
        }




        public void UpdateTasks(List<TaskEmployees> tasks)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var query = "UPDATE taskProjects SET idStatusTask = @idStatusTask WHERE idTask = @idTask";

                        foreach (var task in tasks)
                        {
                            connection.Execute(query, new { idStatusTask = task.idStatusTask, idTask = task.idTask }, transaction);
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void AddTasksEmployees(TaskEmployees taskEmployees)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO taskProjects (codeProject, nameTask, descriptionTask, idEmployee, idStatusTask, dateEnd) 
                                 VALUES(@codeProject, @nameTask, @descriptionTask, @idEmployee, @idStatusTask, @dateEnd)";

                connection.Query<TaskEmployees>(query, new
                {
                    taskEmployees.codeProject,
                    taskEmployees.nameTask,
                    taskEmployees.descriptionTask,
                    taskEmployees.idEmployee,
                    taskEmployees.idStatusTask,
                    taskEmployees.dateEnd
                });
            }
        }

        public IEnumerable<TaskEmployees> GetTasksByCode(string codeProject)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT t.idTask, t.codeProject, t.idEmployee, t.nameTask, t.descriptionTask, t.idStatusTask , te.statusTask, t.fileTask FROM taskProjects t
                                INNER JOIN taskEmployeesStatus te ON te.idStatusTask = t.idStatusTask
                                INNER JOIN employee e ON e.idEmployee = t.idEmployee
                                WHERE t.codeProject = @codeProject";

                return connection.Query<TaskEmployees>(query, new { codeProject });
            }
        }

        public IEnumerable<TaskEmployees> GetByIdTaskEmployee(int idEmployee, int? idStatusTask = null)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT tk.idTask, tk.codeProject, tk.nameTask, tk.descriptionTask, tk.idStatusTask, tk.fileTask FROM taskProjects tk 
                                WHERE tk.idEmployee = @idEmployee";

                if (idStatusTask.HasValue)
                {
                    query += " AND tk.idStatusTask = @idStatusTask";
                }
                return connection.Query<TaskEmployees>(query, new { idEmployee, idStatusTask });
            }
        }


        public byte[] DownloadTask(int idTask)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT fileTask FROM taskProjects WHERE idTask = @idTask";

                return connection.QueryFirstOrDefault<byte[]>(query, new { idTask });
            }
        }

        public byte[] getFileProjectsRefusedInDB(int idProject)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT fileRefused FROM RefusedProject WHERE idProject = @idProject";

                return connection.QueryFirstOrDefault<byte[]>(query, new { idProject });
            }
        }

    }
}
