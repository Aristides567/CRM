using BusinessLayer.Services.InterfacesServices;
using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.InterfacesRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class RolServices : IRolServices
    {
        private IRolRepositories _rolrepositories;

        public RolServices(IRolRepositories rolRepositories)
        {
            _rolrepositories = rolRepositories;
        }

        public IEnumerable<Roll> GetRolFiltro()
        {
            return _rolrepositories.GetRol();
        }

        public IEnumerable<Roll> GetRol()
        {
            return _rolrepositories.GetAllRol();
        }
    }
}
