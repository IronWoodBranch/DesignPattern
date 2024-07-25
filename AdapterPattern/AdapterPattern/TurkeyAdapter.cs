using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class TurkeyAdapter:Duck
    {
        //通过组合拿到adaptee
        Turkey _turkey { get; }

        internal TurkeyAdapter(Turkey turkey)
        {
            this._turkey = turkey;
        }

        //把adaptee的行为包装到要转换的接口里去
        public void quack()
        {
            this._turkey.gobble();
        }

        public void fly()
        {
            this._turkey.fly();
        }
    }
}
