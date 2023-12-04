using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComplex
{
    public class KoncertZaal : IProduct
    {
        public decimal Prijs { get; set; }

        public KoncertZaal(decimal prijs)
        {
            Prijs = prijs;
        }
        public decimal BerekenBelasting()
        {
            return Prijs * 0.6m;
            
        }
    }
}
