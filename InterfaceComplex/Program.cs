using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComplex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProduct belgischProduct = new BelgischeProducten("Sport schoenen",100);
            IProduct importProduct = new ImportPuducten(100, "electronica", true);
            IProduct importProduct1 = new ImportPuducten(100, "sieraden", false);
            IProduct koncertzaal = new KoncertZaal(60);

            Console.WriteLine($"Belasting op Belgisch product: {belgischProduct.BerekenBelasting()}");
            Console.WriteLine($"Belasting op Import product: {importProduct.BerekenBelasting()}");
            Console.WriteLine($"Belasting op Import product: {importProduct1.BerekenBelasting()}");
            Console.WriteLine($"Belasting op Koncert Zaal: {koncertzaal.BerekenBelasting()}");
        }
    }
}
