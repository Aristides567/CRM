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
    public class ProjectsClientServices : IProjectsClientServices
    {
        private readonly IProjectsClientsRepositories _projectsClientsRepositories;

        public ProjectsClientServices(IProjectsClientsRepositories projectsClientsRepositories)
        {
            _projectsClientsRepositories = projectsClientsRepositories;
        }
        public void AddNewProject(string codeProject, int idClient, string nameProject, string descriptionProject) => _projectsClientsRepositories.AddNewProject(codeProject, idClient, nameProject, descriptionProject);
        public List<string> GetRequestProyectsByIdClient(int idClient) => _projectsClientsRepositories.GetRequestProyectsByIdClient(idClient);
        public IEnumerable<RequestProjects> GetProjectsByIdStatus(int idClient, IEnumerable<int> idStatus) => _projectsClientsRepositories.GetProjectsByIdStatus(idClient, idStatus);
        public byte[] getProjectInDB(string codeProject) => _projectsClientsRepositories.getProjectInDB(codeProject);
        public void InsertReasonForRejection(reasonForRejection reason) => _projectsClientsRepositories.InsertReasonForRejection(reason);
        public IEnumerable<RequestProjects> GetsProjectsByIdClient(int idUser, int? idStatusProject = null, int? idClient = null) => _projectsClientsRepositories.GetsProjectsByIdClient(idUser, idStatusProject, idClient);

    }
}
