using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Implementation
{
    internal class WildTurkey:Turkey
    {
        public void gobble()
        {
            Console.WriteLine("gobble gobble");
        }

        public void fly()
        {
            Console.WriteLine("a turkey can fly a short distance");
        }
    }
}
