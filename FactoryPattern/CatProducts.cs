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
            "and posts wrapped in rope to encourage scratching";
        public double ProductPrice { get; set; } = 29.99;
        public void OurSlogan()
        {
            Console.WriteLine("Here at PetMart we pride ourselves on quality. " +
                "Our feline products have been tested and approved by highly trained Calicos. " +
                "So, you can trust that it will satisfy any cat!");
            Console.WriteLine($"This {ProductName} {ProductDescription} and only costs ${ProductPrice}!");
        }
    }
}
