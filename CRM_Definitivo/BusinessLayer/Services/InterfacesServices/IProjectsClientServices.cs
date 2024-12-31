using CommonLayer.Entities.Projects;

namespace BusinessLayer.Services.InterfacesServices
{
    public interface IProjectsClientServices
    {
        void AddNewProject(string codeProject, int idClient, string nameProject, string descriptionProject);
        byte[] getProjectInDB(string codeProject);
        IEnumerable<RequestProjects> GetProjectsByIdStatus(int idClient, IEnumerable<int> idStatus);
        List<string> GetRequestProyectsByIdClient(int idClient);
        void InsertReasonForRejection(reasonForRejection reason);
        IEnumerable<RequestProjects> GetsProjectsByIdClient(int idUser, int? idStatusProject = null, int? idClient = null);

    }
}