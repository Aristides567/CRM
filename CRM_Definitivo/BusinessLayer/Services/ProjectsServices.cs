using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities.Projects;
using DataAccessLayer.Repositories.InterfacesRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ProjectsServices : IProjectsServices
    {
        private readonly IProjectsRepositories _listaProyectosRepositories;

        public ProjectsServices(IProjectsRepositories listaProyectosRepositories)
        {
            _listaProyectosRepositories = listaProyectosRepositories;
        }
        public IEnumerable<Projects> GetAllProjects() => _listaProyectosRepositories.GetAllProjects();
        public IEnumerable<StatusProjects> GetStatusProject() => _listaProyectosRepositories.GetStatusProject();
        public void UpdateTaskEmployee(int idTask, byte[] file, int idStatusTask) => _listaProyectosRepositories.UpdateTaskEmployee(idTask, file, idStatusTask);

        //METODOS PARA PROYECTOS
        public IEnumerable<Projects> GetRequestProjectsByStatus(string statusproject) => _listaProyectosRepositories.GetRequestProjectsByStatus(statusproject);
        public IEnumerable<TaskEmployees> GetTaskEmployees() => _listaProyectosRepositories.GetTaskEmployees();
        public void StatusProject(string codeProject, int idStatusProject) => _listaProyectosRepositories.StatusProject(codeProject, idStatusProject);
        public void UpdateDates(string codeProject, DateTime? dateInit = null, DateTime? dateEnd = null) => _listaProyectosRepositories.UpdateDates(codeProject, dateInit, dateEnd);
        public void SendProjects(string codeProject, byte[] file) => _listaProyectosRepositories.SendProjects( codeProject ,file);
        public byte[] GetFileProjectsRefusedInDB(int idProject) => _listaProyectosRepositories.getFileProjectsRefusedInDB(idProject);


        //metodos crud para tareas
        public void AddTasksEmployees(TaskEmployees taskEmployees) => _listaProyectosRepositories.AddTasksEmployees(taskEmployees);
        public void UpdateTasks(List<TaskEmployees> tasksEmployees) => _listaProyectosRepositories.UpdateTasks(tasksEmployees);
        public IEnumerable<TaskEmployees> GetTasksByCode(string codeProject) => _listaProyectosRepositories.GetTasksByCode(codeProject);
        public byte[] DownloadTask(int idTask) => _listaProyectosRepositories.DownloadTask(idTask);
        public IEnumerable<TaskEmployees> GetByIdTaskEmployee(int idEmployee, int? idStatusTask = null) => _listaProyectosRepositories.GetByIdTaskEmployee(idEmployee, idStatusTask);

    }
}
