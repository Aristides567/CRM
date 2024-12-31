using CommonLayer.Entities.Users;

namespace DataAccessLayer.Repositories.InterfacesRepositories.InterfacesUser
{
    public interface IAdminsRepositories
    {
        void AddUser(User user);
        void ChangePassword(User user);
        void DeleteUser(int idUser);
        void EditAccountUser(User user);
        void EditUser(User user);
        IEnumerable<Admins> GetAdmins();
        IEnumerable<User> GetAllUser();
        IEnumerable<User> GetByIdUsers(int idUser);
        byte[] GetProfileImage(int idUser);
        User? GetUserByeUserAndPassword(string UserAccount, string passworduser);
        void UpdateStatusUser(int idUser, string statususer);
        bool UserExists(string userAccount);
        IEnumerable<User> UserSearch(string search);
    }
}