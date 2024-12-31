using BusinessLayer.Services.InterfacesServices.InterfacesUser;
using CommonLayer.Entities.Users;
using DataAccessLayer.Repositories.InterfacesRepositories.InterfacesUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Users
{
    public class AdminsServices : IAdminsServices
    {
        private readonly IAdminsRepositories _adminsRepositories;

        public AdminsServices(IAdminsRepositories adminsRepositories)
        {
            _adminsRepositories = adminsRepositories;
        }

        public User? Login(string UserAccount, string passwordUser)
        {
            return _adminsRepositories.GetUserByeUserAndPassword(UserAccount, passwordUser);
        }
        public IEnumerable<Admins> GetAdmins() => _adminsRepositories.GetAdmins();
        public IEnumerable<User> GetUsers() => _adminsRepositories.GetAllUser();
        public IEnumerable<User> GetByIdUser(int idUser) => _adminsRepositories.GetByIdUsers(idUser);
        public void AddUsers(User user) => _adminsRepositories.AddUser(user);
        public void EditUsers(User user) => _adminsRepositories.EditUser(user);
        public void EditAccountUser(User user) => _adminsRepositories.EditAccountUser(user);
        public void ChangePassword(User user) => _adminsRepositories.ChangePassword(user);
        public void DeleteUsers(int idUser) => _adminsRepositories.DeleteUser(idUser);
        public byte[] GetProfileImage(int idUser) => _adminsRepositories.GetProfileImage(idUser);
        public void UpdateStatusUser(int idUser, string statususer) => _adminsRepositories.UpdateStatusUser(idUser, statususer);
        public IEnumerable<User> UserSearch(string search) => _adminsRepositories.UserSearch(search);
        public bool UserExists(string userAccount)
        {
            return _adminsRepositories.UserExists(userAccount);
        }
    }
}
