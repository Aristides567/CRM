using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities.Projects
{
    public class reasonForRejection
    {
        public int idRefused { get; set; }
        public int idProject { get; set; }
        public byte[]? fileRefused { get; set; }
    }
}
