using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgInOperSus.Klase
{
    public class Zaliha
    {
        public Guid ZalihaId { get; set; }
        public Guid ArtiklId { get; set; }
        public string Naziv { get; set; }
        public string Kolicina { get; set; }
        public double Cijena { get; set; }
    }
}
