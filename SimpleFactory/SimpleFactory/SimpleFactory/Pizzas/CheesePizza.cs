using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Pizzas
{
    internal class CheesePizza : Pizza
    {
        public string pizzaType { get; set; } = "CheesePizza";
        public override void box()
        {
            Console.WriteLine("cp boxing");
        }

        public override void cut()
        {
            Console.WriteLine("cp cutting");
        }

        public override void prepare()
        {
            Console.WriteLine("chesse boiling");
        }
    }
}
