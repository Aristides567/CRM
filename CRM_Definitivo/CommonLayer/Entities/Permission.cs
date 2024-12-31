using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Permission
    {
        public int idPermission { get; set; }
        public int idMenu { get; set; }
        public string name { get; set; }
        public string NameForm { get; set; }

    }

    public class Menu
    {
        public int idMenu { get; set; }
        public string name { get; set; }
        public string NameForm { get; set; }
    }

    public class Permissions
    {
        public int idPermission { get; set; }
        public int idMenu { get; set; }
        public string nameForm { get; set; }
    }

    public class RolPermission
    {
        public int idRolPermission { get; set; }
        public int idPermission { get; set; }
        public string nameForm { get; set; }
        public int idRoles { get; set; }

    }
}
