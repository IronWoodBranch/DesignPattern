using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Pizzas
{
    internal class PineapplePizza : Pizza
    {
        public string PizzaType { get; set; } = "PineapplePizza";
        public override void box()
        {
            Console.WriteLine("PA boxing");
        }

        public override void cut()
        {
            Console.WriteLine("PA cutting");
        }

        public override void prepare()
        {
            Console.WriteLine("calling an Italian");
        }
    }
}
