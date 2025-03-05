using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolySimple06 // You can use polymorphism to store
                       // different objects in a collection and call the same method 
{

    class Animal
    {
        public virtual void Speak()
    {
            Console.WriteLine("Animal makes a sound");
    }
    }

    class Dog: Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    class Cat: Animal
    {
        public override void Speak()
        {
          Console.WriteLine("Cat meows");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Dog(),
                new Cat(),
                new Dog()
            };

            foreach(Animal a in animals)
            {
                a.Speak(); // Calls the override method in each subclass
            }
        }
    }
}
