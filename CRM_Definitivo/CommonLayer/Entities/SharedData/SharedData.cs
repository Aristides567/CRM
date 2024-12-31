using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities.ViewModel
{
    public class SharedData
    {
        //Datos para RequestClientForm
        public int idProject { get; set; }
        public string codeProyect { get; set; }
        public string Description { get; set; }
        public string nameProject { get; set; }

        //Datos para AssignamentTaskEmployee
        public string DescriptionProject { get; set; }
        public string Client { get; set; }
        public DateTime dateEnd { get; set; }

        public string StatusPDF { get; set; }
    }
}
