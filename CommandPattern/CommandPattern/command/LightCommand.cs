using CommandPattern.VendorProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.command
{
    internal class LightOnCommand:Command
    {
        Light _light { get; }
        public LightOnCommand(Light ligth)
        {
            this._light = ligth;
        }

        public void execute()
        {
            _light.On();
        }
    }
}
