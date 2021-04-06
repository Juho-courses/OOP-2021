using System;

namespace InheritanceAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal(4);
            // dog.MakeSound();
            // Console.WriteLine(AnimalStats.CalculateEyesToLegsRatio(dog));

            // This works until the Dog-class is defined as abstract
            // Dog spot = new Dog();
            // spot.MakeSound();
            // Console.WriteLine(dog.LegCount);
            // spot.Name = "Spot";

            GermanShepherd rex = new GermanShepherd("Rex");
            Console.WriteLine(rex.Name);
            Console.WriteLine(rex.Breed);
            Console.WriteLine(rex.LegCount);
            rex.Bark();

            Console.WriteLine(rex.ToString());
            Console.WriteLine(rex);
        }
    }
}
