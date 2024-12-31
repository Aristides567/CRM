using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace DataAccessLayer.DbSqlDataAccess
{
    public class SqlDataAccess :ISqlDataAccess
    {
        private readonly string _connectionString;

        public SqlDataAccess()
        {
            _connectionString = "Data Source=LAPTOP-PHCFNULN\\SQLEXPRESS;Initial Catalog=SistemaProyectosDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
