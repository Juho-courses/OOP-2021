using System;

namespace InheritanceAnimals
{
    public class Animal
    {
        // instance members
        public int LegCount { get; protected set; }
        public int EyeCount { get; protected set; }

        // class member
        public static int Count { get; private set; } = 0;

        public Animal() { }
        public Animal(int legs, int eyes = 2)
        {
            LegCount = legs;
            EyeCount = eyes;
            Count = Count + 1;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sounds!");
        }

        public static void StaticAnimal()
        {
            Console.WriteLine("StaticAnimal() called");
        }
    }
}