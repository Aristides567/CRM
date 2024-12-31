using BusinessLayer.Services.InterfacesServices.InterfacesUser;
using CommonLayer.Entities.Users;
using DataAccessLayer.DbSqlDataAccess;
using DataAccessLayer.Repositories.InterfacesRepositories.InterfacesUser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Users
{
    public class EmployeeServices : IEmployeeServices
    {
        private IEmployeeRepositories _usuariosrepositoriess;

        public EmployeeServices(IEmployeeRepositories usuarioRepositories)
        {
            _usuariosrepositoriess = usuarioRepositories;
        }

        public IEnumerable<Employees> GetEmployees() => _usuariosrepositoriess.GetEmployee();
        public IEnumerable<Employees> GetByIdEmployees(int idEmployee) => _usuariosrepositoriess.GetByIdEmployee(idEmployee);
        public IEnumerable<Employees> GetInfoEmployee(int idUser) => _usuariosrepositoriess.GetInfoEmployee(idUser);
        public void UpdateWorkstation(Employees employee) => _usuariosrepositoriess.UpdateWorkstation(employee);

    }
}
