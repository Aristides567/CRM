using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities.Projects;
using DataAccessLayer.Repositories.InterfacesRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ProjectsEmnployeesServices : IProjectsEmnployeesServices
    {
        private readonly IProjectsEmployeesRepositories _employeesRepositories;

        public ProjectsEmnployeesServices(IProjectsEmployeesRepositories employeesRepositories)
        {
            _employeesRepositories = employeesRepositories;
        }

        public IEnumerable<TaskEmployees> GetTasksByEmployees(int idEmployee) => _employeesRepositories.GetTasksByEmployees(idEmployee);
        public IEnumerable<TaskEmployees> GetsProjects(int idEmployee) => _employeesRepositories.GetsProjects(idEmployee);
        public IEnumerable<StatusTaskEmployees> GetStatusTaskEmployees() => _employeesRepositories.GetStatusTaskEmployees();
    }
}
