using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Avis
    {
        public int Id { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; } = null!;
        public int ClientId { get; set; }
        public Client Client { get; set; } = null!;
        public int Note { get; set; } // Valeur entre 1 et 5
        public string Commentaire { get; set; } = string.Empty;
    }
}
