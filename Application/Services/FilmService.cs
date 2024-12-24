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
    public class FilmService:IFilmService
    {
        private readonly IFilmRepository _filmRepository;
        private readonly IAvisRepository _avisRepository;
        public FilmService(IFilmRepository filmRepository,IAvisRepository avisRepository)
        {
            _avisRepository = avisRepository;
            _filmRepository = filmRepository;
            
        }
       public  IDictionary<string, List<Film>> ClassifierFilmsParGenre()
        {
            var films=_filmRepository.GetAllFilms();
            var filmsParGenre = films.GroupBy(film => film.Genre).ToDictionary
                (group => group.Key, group => group.ToList());
            return filmsParGenre;


        }
        public void AjouterAvis(int FilmId, int ClientId, string Commentaire, int note)
        {
            var film = _filmRepository.GetFilmById(FilmId);
            if (film == null)
            {
                throw new Exception("Film non trouvé");
            }
            var avis = new Avis
            {
                FilmId = FilmId,
                ClientId = ClientId,
                Commentaire = Commentaire,
                Note = note
            };
            _avisRepository.AddAvis(avis);
        }
        public double CalculerMoyenneNotes(int filmId)
        {
            var film = _filmRepository.GetFilmById(filmId);
            if (film == null)
            {
                    throw new Exception("Film non trouvé");
            }
            // Récupérez les avis pour ce film
            var avis = _avisRepository.GetAvisByFilmId(filmId);
            // Si aucun avis, renvoyez 0 comme moyenne
            if (!avis.Any())
            {
                return 0.0;
            }

            // Calculez la moyenne des notes
            var moyenne = avis.Average(a => a.Note);
            return moyenne;
        }

    }
}
