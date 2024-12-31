using DataAccessLayer.DbConnection;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories.InterfacesRepositories;
using CommonLayer.Entities.Projects;

namespace DataAccessLayer.Repositories
{
    public class ProjectsClientsRepositories : IProjectsClientsRepositories
    {
        private readonly ISqlDataAccess _dbConnection;

        public ProjectsClientsRepositories(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<RequestProjects> GetsProjectsByIdClient(int idUser, int? idStatusProject = null, int? idClient = null)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT r.codeProject, u.UserAccount, r.nameProject, r.descriptionProject, r.[file], st.statusProject, r.dateInit, r.dateEnd, r.dateRegistration FROM RequestProjectClient r
                                 LEFT JOIN RefusedProject rf on rf.idRefused = r.idRefused
                                 LEFT JOIN Clients c on c.idCliente = r.idClient
                                 LEFT JOIN Users u on u.idUser = c.idUser
                                 LEFT JOIN statusProject st on st.idStatusProject = r.idStatusProject
                                 WHERE idClient = @idUser";

                if (idStatusProject.HasValue)
                {
                    query += " AND r.idStatusProject = @idStatusProject";
                }

                if (idClient.HasValue)
                {
                    query += " AND r.idClient = @idClient";
                }

                return connection.Query<RequestProjects>(query, new { idUser, idStatusProject, idClient });
            }
        }

        public List<string> GetRequestProyectsByIdClient(int idClient)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT rp.nameProject FROM RequestProjectClient rp WHERE idClient = @idClient AND idStatusProject = 9";

                return connection.Query<string>(query, new { idClient }).ToList();
            }
        }

        public void AddNewProject(string codeProject, int idClient, string nameProject, string descriptionProject)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO RequestProjectClient (codeProject, idClient, nameProject, descriptionProject) 
                         VALUES (@codeProject, @idClient, @nameProject, @descriptionProject)";

                connection.Execute(query, new
                {
                    codeProject,
                    idClient,
                    nameProject,
                    descriptionProject
                });
            }
        }

        public IEnumerable<RequestProjects> GetProjectsByIdStatus(int idClient, IEnumerable<int> idStatus)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"
            SELECT 
                r.idProject,
                r.codeProject,  
                r.nameProject, 
                r.descriptionProject, 
                r.[file], 
                st.statusProject,  
                r.dateEnd, 
                r.dateRegistration
            FROM 
                RequestProjectClient r
            LEFT JOIN 
                statusProject st ON st.idStatusProject = r.idStatusProject
            WHERE 
                r.idClient = @idClient AND
                r.idStatusProject IN @idStatus";

                return connection.Query<RequestProjects>(query, new { idClient, idStatus });
            }
        }
        public byte[] getProjectInDB(string codeProject)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT [file] FROM RequestProjectClient WHERE codeProject = @codeProject";

                return connection.QueryFirstOrDefault<byte[]>(query, new { codeProject });
            }
        }

        public void InsertReasonForRejection(reasonForRejection reason)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"
        IF EXISTS (SELECT 1 FROM RefusedProject WHERE idProject = @idProject)
        BEGIN
            UPDATE RefusedProject 
            SET fileRefused = @fileRefused
            WHERE idProject = @idProject;
        END
        ELSE
        BEGIN
            INSERT INTO RefusedProject (idProject, fileRefused)
            VALUES (@idProject, @fileRefused);
        END";

                connection.Execute(query, reason);
            }
        }
    }
}
