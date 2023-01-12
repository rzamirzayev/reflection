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
        
        
        public override void feature()
        {
            
            Console.WriteLine("Piano ozellikleri");
            Console.WriteLine("Model:"+Model);
            Console.WriteLine("Brand:"+Brand);
            Console.WriteLine("Price:"+Price+"$");
            Console.WriteLine("Quality:"+Quality);
            Console.WriteLine("Colour:"+colour);
           
            
        }

        
    }
}
