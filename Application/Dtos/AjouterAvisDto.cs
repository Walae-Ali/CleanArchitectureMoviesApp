using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class AjouterAvisDto
    {
        public int ClientId { get; set; }
        public string Commentaire { get; set; }
        public int Note { get; set; }
    }
}
