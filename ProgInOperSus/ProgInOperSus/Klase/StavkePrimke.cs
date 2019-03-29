using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgInOperSus.Klase
{
    public class StavkePrimke
    {
        public Guid StavkePrimkeId { get; set; }
        public Guid StavkaId { get; set; }
        public string Naziv { get; set; }
        public double kolicina { get; set; }
        public double cijena { get; set; }
    }
}
