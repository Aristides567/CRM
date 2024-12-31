using CommonLayer.Entities.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.InterfacesServices.InterfacesUser
{
    public interface IAdminsServices
    {
        void AddUsers(User user);
        void ChangePassword(User user);
        void DeleteUsers(int idUser);
        void EditAccountUser(User user);
        void EditUsers(User user);
        IEnumerable<Admins> GetAdmins();
        IEnumerable<User> GetByIdUser(int idUser);
        byte[] GetProfileImage(int idUser);
        IEnumerable<User> GetUsers();
        User? Login(string UserAccount, string passwordUser);
        void UpdateStatusUser(int idUser, string statususer);
        bool UserExists(string userAccount);
        IEnumerable<User> UserSearch(string search);
    }
}