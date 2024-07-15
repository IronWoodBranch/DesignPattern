using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.condimentsImp
{
    public class Milk:Condiments
    {
        Beverage _beverage { get; set; }
        public string description { get; set; } = "milk";
        public Milk(Beverage beverage)
        {
            this._beverage = beverage;
        }
        public override double cost()
        {
            return _beverage.cost() + 2;
        }
        public override string getDescription()
        {
            return description;
        }
    }
}
