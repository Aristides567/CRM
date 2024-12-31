using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities.Users
{
    public class Employees
    {
        public int idEmployee { get; set; }
        public int idUser { get; set; }
        public string comment { get; set; }
        public string workStation { get; set; }
        public string UserAccount { get; set; }
    }
}
