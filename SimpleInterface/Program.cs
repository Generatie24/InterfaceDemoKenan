using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMachine[] machines = new IMachine[3];
            machines[0] = new CoffeeMachine();
            machines[1] = new Computer();
            machines[2] = new Car();

            foreach (IMachine machine in machines)
            {
                if (machine is CoffeeMachine coffee)
                {
                    coffee.AddSugar();
                }
                machine.Start();
                machine.Stop();
            }


        }
    }
}
