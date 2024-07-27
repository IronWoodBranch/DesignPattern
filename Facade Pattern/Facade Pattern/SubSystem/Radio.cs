using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.SubSystem
{
    internal class Radio
    {
        public void VolunmUp()
        {
            Console.WriteLine("Volunm up");
        }

        public void VolunmDown()
        {
            Console.WriteLine("Volunm down");
        }
    }
}
