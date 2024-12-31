using CommonLayer.Entities;
using Dapper;
using DataAccessLayer.DbConnection;
using DataAccessLayer.DbSqlDataAccess;
using DataAccessLayer.Repositories.InterfacesRepositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RolRepositories : IRolRepositories
    {
        private ISqlDataAccess _dbConnection;

        public RolRepositories(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Roll> GetRol()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT TOP 2 * FROM roles";

                return connection.Query<Roll>(query);
            }
        }

        public IEnumerable<Roll> GetAllRol()
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT idRol, Rol FROM roles";


                return connection.Query<Roll>(query);
            }


        }
    }
}
