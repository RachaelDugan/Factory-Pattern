using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ReptileProducts : IPetProducts
    {
        public string ProductName { get; set; } = "Heat Lamp";
        public string ProductDescription { get; set; } = "features a polished aluminum dome, light & UV output up to 30%. " +
            "Made of heavy gauge painted aluminum, has a ceramic socket and includes On/Off switch for greater convenience";
        public double ProductPrice { get; set; } = 12.99;
        public void OurSlogan()
        {
            Console.WriteLine("Here at PetMart we pride ourselves on quality. " +
                "Our reptile products have been tested and approved by the oldest lizard we could find. " +
                "So, you can trust that it will satisfy any reptile!");
            Console.WriteLine($"This {ProductName} {ProductDescription} and only costs ${ProductPrice}!");
        }
    }
}
