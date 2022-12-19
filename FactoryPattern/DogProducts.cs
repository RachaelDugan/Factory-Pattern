using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class DogProducts : IPetProducts
    {
        public string ProductName { get; set; } = "Dog Bowl";
        public string ProductDescription { get; set; } = "is stainless steel with a deep basin " +
            "and decorative Harliquin pattern around the outside";
        public double ProductPrice { get; set; } = 4.99;
        public void OurSlogan()
        {
            Console.WriteLine("Here at PetMart we pride ourselves on quality. " +
                "Our dog products have been tested and approved by highly trained Pomoranians. " +
                "So, you can trust that it will satisfy any dog!");
            Console.WriteLine($"This {ProductName} {ProductDescription} and only costs ${ProductPrice}!");
        }
        
           
    }
}
