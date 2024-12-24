using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Titre { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public ICollection<Avis> Avis { get; set; } = new List<Avis>();

    }
}
