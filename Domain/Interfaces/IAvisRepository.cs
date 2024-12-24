using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IAvisRepository
    {
        public void AddAvis(Avis avis);
        public IEnumerable<Avis> GetAvisByFilmId(int filmId);

    }
}
