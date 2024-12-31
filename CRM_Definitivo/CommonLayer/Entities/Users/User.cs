using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities.Users
{
    public class User
    {
        public int IdUser { get; set; }
        public string UserAccount { get; set; }
        public int idRol { get; set; }
        public string Rol { get; set; }
        public string NameUser { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string NumberPhone { get; set; }
        public string passworduser { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Statususer { get; set; }
        public byte[] Image { get; set; }
        public DateTime DateRegistration { get; set; }
        public int VerificationCode { get; set; }
    }

}
