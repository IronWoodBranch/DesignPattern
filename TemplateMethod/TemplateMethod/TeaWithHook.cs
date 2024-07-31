using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class TeaWithHook : CaffeinBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("add milk");
        }

        protected override void brew()
        {
            Console.WriteLine("brew tea");
        }

        protected override void pourInCup()
        {
            Console.WriteLine("pour tea");
        }
    }
}
