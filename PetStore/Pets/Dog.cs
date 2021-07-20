using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Pets
{
    class Dog //implicitly internal
    {
        
        // Access Modifiers:
        // private: only things in this class can use it --DEFAULT MODIFIER--IMPLICIT
        // public: everything that can see the class can access it
        // internal: anything in this project can access it
        // protected: anything that inherits from me can access

        // Properties (usually found towards top of the class)

        // public is an accessibility modifier
        // next part of a property is the type
        // then the name of the property
        public string Size { get; set; } //auto-property
        public short Weight { get; private set; }
        public string Name { get; set; }

        // Constructor, constructor method
        public Dog(string name, short weight, string size)
        {
            Name = name;
            Size = size;
            Weight = weight;
        }

        // Method Signature
        // Access Modifier - return type - name - args
        // Void means not returning anything
        public void Bark()
        {
            Console.WriteLine($"{Name} barks noisily.");
        }
        // params are camelCase
        public void Eat(string typeOfFood)
        {
           
            if (typeOfFood.ToLower() == "healthy food")
            {
                Weight -= 1;
            }
            Console.WriteLine($"{Name} ate {typeOfFood}. {Name} weighs {Weight}");
        }
    }
}
