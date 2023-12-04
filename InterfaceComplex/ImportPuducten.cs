using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComplex
{
    public class ImportPuducten : IProduct
    {
        public decimal Prijs { get; set; }
        public string Categorie { get; }
        public bool IsDuurzaam { get; private set; }


        public ImportPuducten(decimal prijs, string categorie, bool isDuurzaam)
        {
            this.Prijs = prijs;
            this.Categorie = categorie;
            this.IsDuurzaam = isDuurzaam;

        }
        public decimal BerekenBelasting()
        {
            decimal basisBelasting = Prijs * 0.30m;
            decimal categorieToeslag = BerekenCategorieToeslag();
            decimal milieuBelasting;
            if (IsDuurzaam)
            {
                milieuBelasting = 0;
            }
            else
            {
                milieuBelasting = Prijs * 0.05m;
            }
            decimal totaalBelasting = basisBelasting + categorieToeslag + milieuBelasting;
            return totaalBelasting;
        }

        private decimal BerekenCategorieToeslag()
        {
            switch (Categorie.ToLower())
            {
                case "electronica":
                    return Prijs * 0.02m; // 2% toeslag
                case "sieraden":
                    return Prijs * 0.05m; // 5% toeslag
                case "kleding":
                    return Prijs * 0.3m; // 30 % toeslag
                default:
                    return 0;
            }
        }

    }
}
