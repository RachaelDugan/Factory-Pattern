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
            Console.ReadLine();
            
        }
    }
}
