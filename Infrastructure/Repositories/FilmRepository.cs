using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public  class FilmRepository:IFilmRepository
    {
        private readonly AppDbContext _context;
        public FilmRepository(AppDbContext context)
        {
            _context = context;
            
        }
        public IEnumerable<Film> GetAllFilms()
        {
            return _context.Films.ToList();

        }
        public Film GetFilmById(int filmId) { return _context.Films.Find(filmId);
        }





    }
}
