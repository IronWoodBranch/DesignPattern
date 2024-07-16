using SimpleFactory.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class PizzaFactory
    {
        public Pizza CreatePizza(string pizzaType)
        {
            if (pizzaType == "CheesePizza")
            {
                return new CheesePizza();
            }
            else if(pizzaType =="PineapplePizza")
            {
                return new PineapplePizza();
            }
            else
            {
                return null;
            }
        }

    }
}
