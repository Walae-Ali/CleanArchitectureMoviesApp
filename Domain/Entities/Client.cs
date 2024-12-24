using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public ICollection<Film> FilmsFavoris { get; set; } = new List<Film>();
        public ICollection<Avis> Avis { get; set; } = new List<Avis>();
    }
}
