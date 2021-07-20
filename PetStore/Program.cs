using PetStore.Pets;
using System;


namespace PetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your dogs name");
            var userNameInput = Console.ReadLine();
            Console.WriteLine($"Enter {userNameInput}'s size");
            var userSizeInput = Console.ReadLine();
            Console.WriteLine($"Enter {userNameInput}'s weight");
            short userWeightInput = short.Parse(Console.ReadLine());

            var dog1= new Dog(userNameInput, userWeightInput, userSizeInput);
            dog1.Bark();
            dog1.Eat("healthy food");

            var daisy = new Dog("Daisy", 50, "Medium");
            daisy.Name = "Daisy";
            daisy.Bark();
            daisy.Eat("unhealthy food");

            // this won't work, can't dynamically add properties to a class in c#
            //melba.CoatType = "short";
        }
    }   
}
