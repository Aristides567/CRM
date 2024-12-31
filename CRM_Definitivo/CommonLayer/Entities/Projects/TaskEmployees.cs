using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities.Projects
{
    public class TaskEmployees
    {
        public int idTask { get; set; }
        public string codeProject { get; set; }
        public string nameTask { get; set; }
        public string descriptionTask { get; set; }
        public int idEmployee { get; set; }
        public int idStatusTask { get; set; }
        public string statusTask { get; set; }
        public byte[] fileTask { get; set; }
        public DateTime dateEnd { get; set; }
    }
}
