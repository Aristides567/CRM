using CommonLayer.Entities.Users;
using Dapper;
using DataAccessLayer.DbConnection;
using DataAccessLayer.Repositories.InterfacesRepositories.InterfacesUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.UsersRepositories
{
    public class ClientsRepositories : IClientsRepositories
    {
        private readonly ISqlDataAccess _dbConnection;

        public ClientsRepositories(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Clients> GetClients()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "select c.idCliente, c.idUser, u.userAccount from Clients c LEFT JOIN Users u on c.idUser = u.idUser";

                return connection.Query<Clients>(query);
            }
        }

        public IEnumerable<Clients> GetByIdClients(int idUser)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"select c.idCliente, c.idUser, u.userAccount from Clients c 
                                 LEFT JOIN Users u on c.idUser = u.idUser
                                 WHERE c.idUser = @idUser";

                return connection.Query<Clients>(query, new { idUser });
            }
        }
    }
}
