﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Flute : Instrument
    {
        public string colour;

        public override void Sound()
        {
            Console.WriteLine("flute sesi");
        }
    }
}
