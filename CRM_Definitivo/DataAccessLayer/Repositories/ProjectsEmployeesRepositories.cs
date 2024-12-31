using CommonLayer.Entities.Projects;
using Dapper;
using DataAccessLayer.DbConnection;
using DataAccessLayer.Repositories.InterfacesRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ProjectsEmployeesRepositories : IProjectsEmployeesRepositories
    {
        private readonly ISqlDataAccess _dbConnection;
        public ProjectsEmployeesRepositories(ISqlDataAccess sqlDataAccess)
        {
            _dbConnection = sqlDataAccess;
        }

        public IEnumerable<TaskEmployees> GetTasksByEmployees(int idEmployee)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT tp.idTask, tp.codeProject, tp.nameTask, tp.descriptionTask FROM taskProjects tp WHERE idEmployee = @idEmployee AND idStatusTask = 3";

                return connection.Query<TaskEmployees>(query, new { idEmployee }).ToList();
            }
        }

        public IEnumerable<TaskEmployees> GetsProjects(int idEmployee)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT tp.idTask, tp.codeProject, tp.idEmployee , u.UserAccount, tp.nameTask, tp.descriptionTask, se.statusTask, tp.dateEnd FROM taskProjects tp
                                LEFT JOIN employee e on e.idEmployee = tp.idEmployee
                                LEFT JOIN Users u on u.idUser = e.idEmployee
                                INNER JOIN taskEmployeesStatus se on se.idStatusTask = tp.idStatusTask
                                WHERE tp.idEmployee = @idEmployee";
                return connection.Query<TaskEmployees>(query, new { idEmployee });
            }
        }

        public IEnumerable<StatusTaskEmployees> GetStatusTaskEmployees()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT idStatusTask, statusTask FROM taskEmployeesStatus";
                return connection.Query<StatusTaskEmployees>(query);
            }
        }
    }

}
