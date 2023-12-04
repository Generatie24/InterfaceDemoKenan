using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterface
{
    public class CoffeeMachine : IMachine
    {
        public void AddSugar()
        {
            Console.WriteLine("Sugar added");
        }
        public void Start()
        {
            Console.WriteLine("Coffee machine started, and the coffee is ready");
        }

        public void Stop()
        {
            Console.WriteLine("Coffee machine stopped, Take your coffee");

        }
    }
}
