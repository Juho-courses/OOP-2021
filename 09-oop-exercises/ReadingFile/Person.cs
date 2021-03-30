using System;

namespace ReadingFile
{
    public class Person
    {
        // name age
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Print()
        {
            Console.WriteLine("Name: " + Name + ", Age: " + Age);
        }

    }
}