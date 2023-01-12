using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class guitar : Instrument
    {
        public string colour;
        public override void feature()
        {
            Console.WriteLine("Gitar ozellikleri");
            Console.WriteLine("Model:" + Model);
            Console.WriteLine("Brand:" + Brand);
            Console.WriteLine("Price:" + Price + "$");
            Console.WriteLine("Quality:" + Quality);
            Console.WriteLine("Colour:" + colour);
        }
    }
}
