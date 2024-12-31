using CommonLayer.Entities.Projects;

namespace BusinessLayer.Services.InterfacesServices
{
    public interface IProjectsEmnployeesServices
    {
        IEnumerable<TaskEmployees> GetsProjects(int idEmployee);
        IEnumerable<StatusTaskEmployees> GetStatusTaskEmployees();
        IEnumerable<TaskEmployees> GetTasksByEmployees(int idEmployee);
    }
}