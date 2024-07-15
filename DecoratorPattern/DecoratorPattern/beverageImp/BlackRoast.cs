using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.beverageImp
{
    public class BlackRoast:Beverage
    {
        public double coffeeCost { get; set; } = 5;
        public string description { get; } = "BlackRoast";

        public override double cost()
        {
            return coffeeCost;
        }
    }
}
