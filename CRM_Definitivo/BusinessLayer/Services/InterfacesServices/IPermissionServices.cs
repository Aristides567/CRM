using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.InterfacesServices
{
    public interface IPermisoServices
    {
        void AddMenu(Menu menu);
        void AddPermissions(Permissions permissions);
        void AddRolPermission(RolPermission rolpermission);
        void DeleteMenu(int idMenu);
        void EditMenu(Menu menu);
        void EditPermissions(Permissions permissions);
        void EditRolPermission(RolPermission rolpermission);
        IEnumerable<Menu> GetByMenu();
        IEnumerable<RolPermission> GetByRolPermissions();
        IEnumerable<Permission> GetPermisos(int idUser);
        IEnumerable<Permissions> GetPermissions();
    }
}
