using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class CatProducts : IPetProducts
    {
        public string ProductName { get; set; } = "Cat Stratching Post";
        public string ProductDescription { get; set; } = "is 3 foot high with carpeted platforms " +
            "and posts wrapped \nin rope to encourage scratching";
        public double ProductPrice { get; set; } = 29.99;
        public string Guarantee { get; set; } = "Our feline products have been tested \nand approved by highly trained Calios.";
        public void OurSlogan()
        {
            Console.WriteLine();
            Console.WriteLine($"Here at PetMart we pride ourselves on quality.\n{Guarantee}"); 
            Console.WriteLine("So, you can trust that it will satisfy any cat!");
            Console.WriteLine();
            Console.WriteLine($"This {ProductName} {ProductDescription} and only costs ${ProductPrice}!");
        }
    }
}
