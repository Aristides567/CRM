using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class EmailSettings
    {
        public string EmailOrigen { get; set; } = "soportes.proyectostl@gmail.com";
        public string EmailDestino { get; set; } = string.Empty;
        public string Contraseña { get; set; } = "dztopjihnjholgcv";
        public string codigoVerificacion { get; set; } = string.Empty;
        public string metodoVerificacion { get; set; } = string.Empty;
    }
}
