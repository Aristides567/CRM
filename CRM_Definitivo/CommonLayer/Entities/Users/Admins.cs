using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities.Users
{
    public class Admins
    {
        public int idAdmin { get; set; }
        public int idUser { get; set; }
        public string UserAccount { get; set; }
    }
}
