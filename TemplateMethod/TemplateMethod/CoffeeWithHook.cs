using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class CoffeeWithHook : CaffeinBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("add syrup");
        }

        protected override void brew()
        {
            Console.WriteLine("brew coffe");
        }

        protected override void pourInCup()
        {
            Console.WriteLine("pour coffee in ");
        }
    }
}
