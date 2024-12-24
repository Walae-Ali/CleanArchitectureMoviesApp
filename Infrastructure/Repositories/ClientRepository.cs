using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ClientRepository:IClientRepository
    {
        private readonly AppDbContext _context;

        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Film> GetFavoriteMovies(int clientId)
        {
            var client = _context.Clients
                .Include(c => c.FilmsFavoris)
                .FirstOrDefault(c => c.Id == clientId);

            return client?.FilmsFavoris ?? Enumerable.Empty<Film>();
        }

    }
}
