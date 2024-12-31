using CommonLayer.Entities.Projects;

namespace DataAccessLayer.Repositories.InterfacesRepositories
{
    public interface IProjectsClientsRepositories
    {
        void AddNewProject(string codeProject, int idClient, string nameProject, string descriptionProject);
        IEnumerable<RequestProjects> GetProjectsByIdStatus(int idClient, IEnumerable<int> idStatus);
        byte[] getProjectInDB(string codeProject);
        List<string> GetRequestProyectsByIdClient(int idClient);
        void InsertReasonForRejection(reasonForRejection reason);
        IEnumerable<RequestProjects> GetsProjectsByIdClient(int idUser, int? idStatusProject = null, int? idClient = null);
    }
}