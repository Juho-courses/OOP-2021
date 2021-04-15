using System;
using System.Collections.Generic;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string key;

            // people = GenPeople();

            PrintHelp();

            while (true)
            {
                key = WaitUserInput();

                if (key.Equals("L"))
                {
                    PrintPeople(people);
                }
                else if (key.Equals("LA"))
                {
                    PrintPeople(people, "adult");
                }
                else if (key.Equals("LC"))
                {
                    PrintPeople(people, "child");
                }
                else if (key.Equals("Q"))
                {
                    return;
                }
                else if (key.Equals("A"))
                {
                    Person p = AskPerson();
                    people.Add(p);
                    Console.WriteLine("User added!");
                }
                else
                {
                    PrintHelp();
                }
            }


        }


        static Person AskPerson()
        {
            Console.Write("Name: ");
            string _name = Console.ReadLine();

            Console.Write("Age: ");
            int _age = Int16.Parse(Console.ReadLine());

            if (_age < 18)
            {
                Console.Write("Bike: ");
                string _bike = Console.ReadLine();
                Child c = new Child(_name, _age);
                c.Bike = _bike;
                return c;
            }
            else
            {
                Console.Write("Car: ");
                string _car = Console.ReadLine();
                Adult a = new Adult(_name, _age);
                a.Car = _car;
                return a;
            }
        }

        static void PrintPeople(List<Person> people, string type = "all")
        {
            if (people.Count == 0)
            {
                Console.WriteLine("No people!");
                return;
            }
            foreach (Person p in people)
            {
                if (type.Equals("all"))
                {
                    Console.WriteLine(p);
                }
                if (p.Type.Equals(type))
                {
                    Console.WriteLine(p);
                }
            }
        }

        static string WaitUserInput()
        {
            Console.Write("Enter command: ");
            string key = Console.ReadLine();
            return key;
        }

        static void PrintHelp()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("A: Add a person");
            Console.WriteLine("L: List all people");
            Console.WriteLine("LA: List only adults");
            Console.WriteLine("LC: List only children");
            Console.WriteLine("Q: Exit the app");
            Console.WriteLine("--------");
        }

        static public List<Person> GenPeople(int n = 2)
        {
            List<Person> peeps = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                Child c = new Child($"C{i}", (17 - i));
                c.Bike = "Nishiki";
                peeps.Add(c);
            }
            for (int i = 0; i < n; i++)
            {
                Adult a = new Adult($"A{i}", (18 + i));
                a.Car = "Skoda";
                peeps.Add(a);
            }

            return peeps;
        }
    }
}
