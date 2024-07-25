using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Implementation
{
    internal class MallardDuck:Duck
    {
        public void quack()
        {
            Console.WriteLine("quack");
        }
        public void fly()
        {
            Console.WriteLine("I do not fly");
        }
    }
}
