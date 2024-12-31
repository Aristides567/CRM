using CommonLayer.Entities.Projects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.InterfacesRepositories
{
    public interface IProjectsRepositories
    {
        IEnumerable<Projects> GetAllProjects();
        IEnumerable<StatusProjects> GetStatusProject();
        void UpdateTaskEmployee(int idTask, byte[] file, int idStatusTask);

        //proyectos
        IEnumerable<Projects> GetRequestProjectsByStatus(string statusProject);
        IEnumerable<TaskEmployees> GetTaskEmployees();
        void StatusProject(string codeProject, int idStatusProject);
        void UpdateDates(string codeProject, DateTime? dateInit = null, DateTime? dateEnd = null);
        void SendProjects(string codeProject, byte[] file);

        //metodos para tareas
        void AddTasksEmployees(TaskEmployees taskEmployees);
        IEnumerable<TaskEmployees> GetTasksByCode(string codeProject);
        byte[] DownloadTask(int idTask);
        IEnumerable<TaskEmployees> GetByIdTaskEmployee(int idEmployee, int? idStatusTask = null);
        byte[] getFileProjectsRefusedInDB(int idProject);
        void UpdateTasks(List<TaskEmployees> tasks);
        
    }
}
