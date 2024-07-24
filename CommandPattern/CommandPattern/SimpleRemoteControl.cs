using CommandPattern.command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class SimpleRemoteControl
    {
        //通过多态，动态地引入Command
        Command slot;
        public SimpleRemoteControl()
        {
        }

        //把别的对象封装起来当作请求传递
        public void setCommand(Command command)
        {
            slot = command;
        }

        public void buttonWasPressed()
        {
            slot.execute();
        }
    }
}
