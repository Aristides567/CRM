using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities.Projects
{
    public class Projects
    {
        public int idProject { get; set; }
        public string codeProject { get; set; }
        public string UserAccount { get; set; }
        public string nameProject { get; set; }
        public string descriptionProject { get; set; }
        public byte[] file { get; set; }
        public string statusProject { get; set; }
        public DateTime dateInit { get; set; }
        public DateTime dateEnd { get; set; }
        public DateTime dateRegistration { get; set; }


    }
}
