using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.InterfacesRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class PermissionServices : IPermisoServices
    {
        private IPermissionRepositories _permisosrepositories;

        public PermissionServices(IPermissionRepositories permisosRepositories)
        {
            _permisosrepositories = permisosRepositories;
        }

        //PERMISOS PARA LOGIN
        public IEnumerable<Permission> GetPermisos(int idUser)
        {
            return _permisosrepositories.GetAllPermiso(idUser);
        }

        //PERMISOS menu CRUD
        public IEnumerable<Menu> GetByMenu()
        {
            return _permisosrepositories.GetByMenus();
        }
        public void AddMenu(Menu menu)
        {
            _permisosrepositories.AddMenus(menu);
        }
        public void EditMenu(Menu menu)
        {
            _permisosrepositories.EditMenus(menu);
        }
        public void DeleteMenu(int idMenu)
        {
            _permisosrepositories.DeleteMenus(idMenu);
        }

        //PERMISOS CRUD
        public IEnumerable<Permissions> GetPermissions()
        {
            return _permisosrepositories.GetPermissions();
        }
        public void AddPermissions(Permissions permissions)
        {
            _permisosrepositories.AddPermissions(permissions);
        }
        public void EditPermissions(Permissions permissions)
        {
            _permisosrepositories.EditPermissions(permissions);
        }


        //PERMISOS CRUD
        public IEnumerable<RolPermission> GetByRolPermissions()
        {
            return _permisosrepositories.GetRolPermissions();
        }
        public void AddRolPermission(RolPermission rolpermission)
        {
            _permisosrepositories.AddRolPermissions(rolpermission);
        }
        public void EditRolPermission(RolPermission rolpermission)
        {
            _permisosrepositories.EditRolPermissions(rolpermission);
        }
    }
}
