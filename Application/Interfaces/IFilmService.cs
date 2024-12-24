using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IFilmService
    {
        public IDictionary<string, List<Film>> ClassifierFilmsParGenre();
        public void AjouterAvis(int FilmId,int ClientId,string Commentaire,int note);
        public double CalculerMoyenneNotes(int filmId);

    }
}
