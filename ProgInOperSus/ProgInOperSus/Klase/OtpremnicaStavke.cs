using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgInOperSus.Klase
{
    public class OtpremnicaStavke
    {
        public Guid OtpremnicaStavkeId { get; set; }
        public Guid OtpremnicaId { get; set; }
        public string Naziv { get; set; }
        public double Vpc { get; set; }
    }
}
