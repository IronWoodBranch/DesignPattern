using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class GumballMachine
    {
        private StateEnum state { get; set; } = StateEnum.SOLD_OUT;

    }
}
