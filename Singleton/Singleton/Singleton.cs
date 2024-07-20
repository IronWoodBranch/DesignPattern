using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Singleton
    {
        private static Singleton _singleton;
        public static Singleton getSingleInstance()
        {
            if(_singleton==null)
            {
                _singleton =new Singleton();
            }
                return _singleton;
        }
        private Singleton()
        {
        }

        public void testMethod()
        {
            Console.WriteLine("singleton method");
        }
    }
}
