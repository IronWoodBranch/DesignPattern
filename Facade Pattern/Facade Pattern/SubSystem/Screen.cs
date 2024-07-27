using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern.SubSystem
{
    internal class Screen
    {
        public void down()
        {
            Console.WriteLine("screen down");
        }
        public void up()
        {
            Console.WriteLine("screen up");
        }
    }
}
