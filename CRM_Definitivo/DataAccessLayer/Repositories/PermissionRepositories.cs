using CommonLayer.Entities;
using Dapper;
using DataAccessLayer.DbConnection;
using DataAccessLayer.DbSqlDataAccess;
using DataAccessLayer.Repositories.InterfacesRepositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PermissionRepositories : IPermissionRepositories
    {
        private ISqlDataAccess _dbConnection;

        public PermissionRepositories(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Permission> GetAllPermiso(int idUser)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT r.idRol, m.nameForm , p.idPermission FROM rolPermission rp
                                JOIN roles r ON rp.idRoles = r.idRol
                                JOIN permission p ON rp.idPermission = p.idPermission
                                JOIN menu m ON p.idMenu = m.idMenu
                                JOIN users u on u.idRol = r.idRol
                               WHERE u.idUser = @idUser";

                return connection.Query<Permission>(query, new { idUser });
            }
        }

        //CRUD DE MENUS
        public IEnumerable<Menu> GetByMenus()
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT * FROM menu";

                return connection.Query<Menu>(query);
            }
        }

        public void AddMenus(Menu menu)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO menu(name, nameForm)
                                 VALUES(@name, @nameForm)";

                connection.Query<Menu>(query, new
                {
                    menu.name,
                    menu.NameForm
                });
            }
        }
        
        public void EditMenus(Menu menu)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE menu SET
                                    name = @name,
                                    nameForm = @nameForm
                                 WHERE idMenu = @idMenu";

                connection.Query<Menu>(query, menu);
            }
        }

        public void DeleteMenus(int idMenu)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM menu WHERE idMenu = @idMenu";

                connection.Query(query, new { idMenu });
            }
        }

        //CRUD DE PERMISOS

        public IEnumerable<Permissions> GetPermissions()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT p.idPermission, p.idMenu, m.nameForm FROM permission p
                               LEFT JOIN menu m on p.idMenu = m.idMenu";

                return connection.Query<Permissions>(query);
            }
        }
        public void AddPermissions(Permissions permissions)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO permission(idMenu)
                                 VALUES(@idMenu)";

                connection.Query<Permissions>(query, new
                {
                    permissions.idMenu
                });
            }
        }

        public void EditPermissions(Permissions permissions)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE permission SET
                                 idMenu = @idMenu
                                 WHERE idPermission = @idPermission";

                connection.Query<Permissions>(query, permissions);
            }
        }


        //CRUD PARA LA TABLA RolPermission
        public IEnumerable<RolPermission> GetRolPermissions()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT rp.idRolPermission, rp.idPermission, m.nameForm, rp.idRoles FROM rolPermission rp
							    LEFT JOIN permission p on rp.idPermission = p.idPermission
							    LEFT JOIN menu m on p.idMenu = m.idMenu";

                return connection.Query<RolPermission>(query);
            }
        }
        public void AddRolPermissions(RolPermission RolPermission)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO rolPermission(idRoles, idPermission)
                                 VALUES(@idRoles, @idPermission)";

                connection.Query<Permission>(query, new
                {
                    RolPermission.idRoles,
                    RolPermission.idPermission
                });
            }
        }

        public void EditRolPermissions(RolPermission rolPermission)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE rolPermission SET
                                 idRoles = @idRoles,
                                 idPermission = @idPermission
                                 WHERE idRolPermission = @idRolPermission";

                connection.Query<RolPermission>(query, rolPermission);
            }
        }
    }
}
