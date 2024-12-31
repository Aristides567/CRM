using CommonLayer.Entities.Users;
using Dapper;
using DataAccessLayer.DbConnection;
using DataAccessLayer.Repositories.InterfacesRepositories.InterfacesUser;
using DataAccessLayer.DbSqlDataAccess;
using DataAccessLayer.Repositories.InterfacesRepositories;
using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DataAccessLayer.Repositories.UsersRepositories
{
    public class EmployeeRepositories : InterfacesRepositories.InterfacesUser.IEmployeeRepositories
    {
        private readonly ISqlDataAccess _dbConnection;

        public EmployeeRepositories(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }
      
        public IEnumerable<Employees> GetEmployee()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "select e.idEmployee, e.idUser, e.comment, e.workStation, u.UserAccount from employee e LEFT JOIN Users u on e.idUser = u.idUser";

                return connection.Query<Employees>(query);
            }
        }

        public IEnumerable<Employees> GetByIdEmployee(int idEmployee)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT e.idEmployee, e.idUser FROM Employee e LEFT JOIN Users u on e.idUser = u.idUser WHERE e.idUser = @idEmployee";

                return connection.Query<Employees>(query, new { idEmployee });
            }
        }

        public IEnumerable<Employees> GetInfoEmployee(int idUser)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT e.idEmployee, e.idUser, e.comment, e.workStattion FROM Employee e LEFT JOIN Users u on e.idUser = u.idUser WHERE e.idUser = @idUser";

                return connection.Query<Employees>(query, new { idUser });
            }
        }

        public void UpdateWorkstation(Employees employee)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE employee SET
                                     comment = @comment,
                                     workStation = @workStation
                                 WHERE idEmployee = (SELECT MAX(idEmployee) FROM employee)";
                connection.Query<Employees>(query, employee);
            }
        }        

    }
}
