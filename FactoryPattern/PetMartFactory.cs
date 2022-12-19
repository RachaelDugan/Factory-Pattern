using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class PetMartFactory
    {
        public static IPetProducts CustomersPet(string petType)
        {
            switch (petType.ToLower())
            {
                case "reptile":
                    return new ReptileProducts();

                case "dog":
                    return new DogProducts();

                case "cat":
                    return new CatProducts();
                default:
                    Console.WriteLine("Unable to find that type, here is cat info:");
                    return new CatProducts();
            }
            
        }
    }
}
