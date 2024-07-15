using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        //description of coffee
        public string description{ get; }

        public abstract double cost();

    }
}
