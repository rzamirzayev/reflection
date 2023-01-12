using Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;


List<object> Insturments = new List<object>();
Piano piano = new Piano();
piano.Model = "Electronic";
piano.Brand = "Bosendorfer";
piano.Price = 20000;
piano.Quality = "High";
piano.colour = "Black";
Insturments.Add(piano);

guitar guitar = new guitar();
guitar.Model = "Classical";
guitar.Brand = "Fazioli";
guitar.Price = 3000;
guitar.Quality = "Middle";
guitar.colour = "White";
Insturments.Add(guitar);

Flute flute = new Flute();
flute.Model = "piccolo";
flute.Brand = "Yamaha";
flute.Price = 70;
flute.Quality = "Low";
flute.colour = "Pink";
Insturments.Add(flute);

violin violin = new violin();
violin.Model = "cello";
violin.Brand = "Jupier";
violin.Price = 6000;
violin.Quality = "High";
violin.colour = "orange";
Insturments.Add(violin);



for(int i = 0; i < Insturments.Count; i++)
{
    FieldInfo[] fields = Insturments[i].GetType().GetFields();
    foreach(FieldInfo item in fields)
    {
        Console.WriteLine(item.Name + ":" + item.GetValue(Insturments[i]));      
    }
    Console.WriteLine("      ");
}








