using CommonLayer.Entities.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.InterfacesRepositories.InterfacesUser
{
    public interface IEmployeeRepositories
    {

        IEnumerable<Employees> GetEmployee();
        IEnumerable<Employees> GetByIdEmployee(int idEmployee);
        void UpdateWorkstation(Employees employee);
        IEnumerable<Employees> GetInfoEmployee(int idUser);
    }
}
