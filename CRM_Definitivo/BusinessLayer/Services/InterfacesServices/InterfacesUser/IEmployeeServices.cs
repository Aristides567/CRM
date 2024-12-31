using CommonLayer.Entities.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.InterfacesServices.InterfacesUser
{
    public interface IEmployeeServices
    {
        IEnumerable<Employees> GetEmployees();
        IEnumerable<Employees> GetByIdEmployees(int idEmployee);
        void UpdateWorkstation(Employees employee);
        IEnumerable<Employees> GetInfoEmployee(int idUser);

    }
}
