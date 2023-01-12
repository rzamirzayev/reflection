using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Reflection
{
    internal class Piano:Instrument
    {
        
        public string colour { get; set; }

        public override void Sound()
        {
            Console.WriteLine("piano sesi");
        }
    }
}
