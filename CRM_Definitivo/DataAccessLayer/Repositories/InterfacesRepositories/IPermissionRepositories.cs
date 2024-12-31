using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.InterfacesRepositories
{
    public interface IPermissionRepositories
    {
        void AddMenus(Menu menu);
        void AddPermissions(Permissions permissions);
        void AddRolPermissions(RolPermission rolPermission);
        void DeleteMenus(int idMenu);
        void EditMenus(Menu menu);
        void EditPermissions(Permissions permissions);
        void EditRolPermissions(RolPermission rolPermission);
        IEnumerable<Permission> GetAllPermiso(int idUser);
        IEnumerable<Menu> GetByMenus();
        IEnumerable<Permissions> GetPermissions();
        IEnumerable<RolPermission> GetRolPermissions();
    }
}
