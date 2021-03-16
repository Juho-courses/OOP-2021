using System;

namespace PersonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            // Console.WriteLine(p1.firstName);
            // Console.WriteLine(p1.GetFirstName());
            // Console.WriteLine(p1.FirstName);
            // Console.WriteLine(p1.lastName);

            // p1.firstName = "Matt";
            // Console.WriteLine(p1.firstName);

            // Console.WriteLine(p1.GetFullName());

            Person p2 = new Person("John", "Smith");
            Console.WriteLine(p2.GetFullName());
            Console.WriteLine(p2.FirstName);


            p2.FirstName = "Roger";

            Console.WriteLine(p2.FirstName);

            Console.WriteLine(p2.IsStudying);
            p2.IsStudying = true;
            Console.WriteLine(p2.IsStudying);

            Console.WriteLine(p2.FullName);

        }
    }
}
