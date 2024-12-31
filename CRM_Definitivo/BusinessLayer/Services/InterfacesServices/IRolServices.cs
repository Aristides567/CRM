using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.InterfacesServices
{
    public interface IRolServices
    {
        IEnumerable<Roll> GetRolFiltro();
        IEnumerable<Roll> GetRol();
    }
}
