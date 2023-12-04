using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComplex
{
    public class BelgischeProducten : IProduct
    {
        public string Naam { get; set; }
        public decimal Prijs { get; set; }

        public decimal BerekenBelasting()
        {
            return Prijs * 0.21m;
        }

        public BelgischeProducten(string naam, decimal prijs)
        {
            this.Naam = naam;
            this.Prijs = prijs;
        }


    }
}
