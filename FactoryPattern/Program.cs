using System;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PetMart Online ordering system.");
            Console.WriteLine("Is your pet a Dog, Cat, or Reptile?");
            var pettype = Console.ReadLine();
            IPetProducts productInstance = PetMartFactory.CustomersPet(pettype);
            productInstance.OurSlogan();
            Console.WriteLine("Do you have another pet?");

            
            var answer = Console.ReadLine();

            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("Happy to assist you with your next pet!");
                Console.WriteLine("Is your pet a Dog, Cat, or Reptile?");
                pettype = Console.ReadLine();
                productInstance = PetMartFactory.CustomersPet(pettype);
                productInstance.OurSlogan();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Thank you for shopping with PetMart");
            }
        }
    }
}
            

           

