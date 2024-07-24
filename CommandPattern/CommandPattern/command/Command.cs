using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.command
{

    internal interface Command
    {
        //所有的命令只有这一个方法
        public void execute();
    }
}
