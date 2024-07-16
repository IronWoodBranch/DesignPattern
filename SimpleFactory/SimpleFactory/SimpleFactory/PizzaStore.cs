using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class PizzaStore
    {
        public PizzaFactory _pizzaFactory { get; set; } = new PizzaFactory();
        Pizza _pizza { get; set; }
        public void ServeOrder(string pizzaType)
        {
            _pizza = _pizzaFactory.CreatePizza(pizzaType);

            _pizza.cut();
            _pizza.prepare();
            _pizza.box();
            Console.WriteLine("serve");
        }
    }
}
