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
        public LightOnCommand(Light light)
        {
            this._light = light;
        }

        public void execute()
        {
            _light.On();
        }
    }
}
