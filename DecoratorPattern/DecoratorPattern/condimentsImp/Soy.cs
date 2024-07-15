using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.condimentsImp
{
    public  class Soy:Condiments
    {
        Beverage _beverage { get; set; }

        public string description { get; set; } = "soy";
        public Soy(Beverage beverage)
        {
            this._beverage = beverage;
        }
        public override string getDescription()
        {
            return description;
        }
        public override double cost()
        {
            return _beverage.cost() + 3;
        }
    }
}
