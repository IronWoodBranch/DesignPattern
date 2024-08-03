using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    internal class GumballMachine
    {
        public StateEnum state { get; set; } = StateEnum.SOLD_OUT;
        private int count { get; set; }

        //构造函数里面再设置一下状态
        public GumballMachine(int count)
        {
            this.count = count;
            if(count>0)
            {
                state = StateEnum.NO_QUARTER;
            }
        }

        #region `insertQuarters
        public void insertQuarters()
        {
            if (state == StateEnum.HAS_QUARTER)
            {
                Console.WriteLine("you can only insert one coin at the same time ");
            }
            else if(state == StateEnum.NO_QUARTER)
            {
                state = StateEnum.HAS_QUARTER;
                Console.WriteLine("inserted");
            }
            else if(state==StateEnum.SOLD_OUT)
            {
                Console.WriteLine("the machine is sold out");
            }
            else if(state==StateEnum.SOLD)
            {
                Console.WriteLine("we're already giving you a gumball");
            }
        }
        #endregion

        #region ejectQuarters
        public void ejectQuarters()
        {
            if(state==StateEnum.NO_QUARTER)
            {
                Console.WriteLine("you havn't inserted a quarter");
            }
            else if(state == StateEnum.HAS_QUARTER)
            {
                Console.WriteLine("your coin returned");
            }
            else if (state == StateEnum.SOLD_OUT)
            {
                Console.WriteLine("Sorry, you already turned the crank");
            }
            else if (state == StateEnum.SOLD)
            {
                Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
            }
        }
        #endregion

        #region truncrank
        public void truncrank()
        {

            if(state==StateEnum.SOLD_OUT)
            {
                Console.WriteLine("sold out,no gumballs");
            }
            else if(state==StateEnum.NO_QUARTER)
            {
                Console.WriteLine("pay a coin to truncrank");
            }
            else if(state==StateEnum.HAS_QUARTER)
            {
                Console.WriteLine("giving...");
            }

        }
        #endregion

        #region dispense
        public void dispense()
        {
            if(state==StateEnum.SOLD)
            {
                Console.WriteLine("A gumball comes rolling out the slot");
                count = count - 1;
                if(count==0)
                {
                    state = StateEnum.SOLD_OUT;
                }
                else
                {
                    state = StateEnum.NO_QUARTER;
                }
            }
            else if(state == StateEnum.NO_QUARTER)
            {
                Console.WriteLine("you need to pay first");

            }
            else if(state == StateEnum.HAS_QUARTER)
            {
                Console.WriteLine("you need to turn the crank");
            }
        }
        #endregion
    }
}
