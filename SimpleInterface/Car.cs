using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterface
{
    public class Car : IMachine
    {
        public void Start()
        {
            Console.WriteLine("Car started");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped");

        }
    }

}
