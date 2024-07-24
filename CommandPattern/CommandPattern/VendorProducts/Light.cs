using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.VendorProducts
{
    internal class Light
    {
        public bool isLightOn  { get; set; }
    
        //开关灯两个具体方法
        public void On()
        {
            this.isLightOn = true;
            Console.WriteLine("light on?:" + this.isLightOn);
        }

        public void Off()
        {
            this.isLightOn = false;
            Console.WriteLine("light on?:"+this.isLightOn);
        }
    }
}
