using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Reflection
{
    internal class guitar : Instrument
    {
        public string colour;

        public override void Sound()
        {
            Console.WriteLine("guitar");
        }
    }
}
