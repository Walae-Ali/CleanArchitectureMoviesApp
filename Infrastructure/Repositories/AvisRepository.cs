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
    public class AvisRepository:IAvisRepository
    {
        private readonly AppDbContext _context;
        public AvisRepository(AppDbContext context) { 
        _context = context;
        }
        public void AddAvis(Avis avis)
        {
            _context.Avis.Add(avis);
            _context.SaveChanges();
        }
        public IEnumerable<Avis> GetAvisByFilmId(int filmId)
        {
            return _context.Avis
            .Where(a => a.FilmId == filmId)
            .ToList();
        }
    }
}
