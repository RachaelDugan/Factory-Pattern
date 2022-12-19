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
                case "Reptile":
                    return new ReptileProducts();

                case "Dog":
                    return new DogProducts();

                case "Cat":
                    return new CatProducts();

                default:
                    return new CatProducts();
            }
            
        }
        
    }
}
