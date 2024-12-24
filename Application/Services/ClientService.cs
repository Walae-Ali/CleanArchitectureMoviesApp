using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ClientService:IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
               _clientRepository = clientRepository;
        }
        public IEnumerable<Film> GetFavoriteMovies(int clientId)
        {
            return _clientRepository.GetFavoriteMovies(clientId);
        }

    }
}
