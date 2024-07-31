using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TemplateMethod
{
    internal abstract class CaffeinBeverage
    {
        public void prepareRecipe()
        {
            boil();
            brew();
            pourInCup();

            //这里留了一个钩子，可以让用户自定义在某个节点要做什么反应
            if(customerWantsCondiments())
            {
                AddCondiments();
            }

        }
        void boil()
        {
            Console.WriteLine("boiling");
        }
        protected abstract void brew();
        protected abstract void pourInCup();

        protected abstract void AddCondiments();
        bool customerWantsCondiments()
        {
            return true;
        }
    }
}
