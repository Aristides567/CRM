using BusinessLayer.Services.InterfacesServices.InterfacesUser;
using CommonLayer.Entities.Users;
using DataAccessLayer.Repositories.InterfacesRepositories.InterfacesUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Users
{
    public class ClientsServices : IClientsServices
    {
        private readonly IClientsRepositories _clientsRepositories;

        public ClientsServices(IClientsRepositories clientsRepositories)
        {
            _clientsRepositories = clientsRepositories;
        }

        public IEnumerable<Clients> GetClients() => _clientsRepositories.GetClients();
        public IEnumerable<Clients> GetByIdClients(int idUser) => _clientsRepositories.GetByIdClients(idUser);
    }
}
