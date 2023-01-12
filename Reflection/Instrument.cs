using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    abstract class Instrument
    {
        public string Model;
        public string Brand;
        public int Price;
        public string Quality;
        abstract public void Sound();
      
        

    }
}
