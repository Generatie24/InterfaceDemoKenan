using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterface
{
    public class Computer : IMachine
    {
        public void Start()
        {
            Console.WriteLine("Computer started working");
        }

        public void Stop()
        {
            Console.WriteLine("Computer shuted down");
        }
    }
}
