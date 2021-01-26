using System;

namespace basics_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // string name = "Juho";

            // Console.WriteLine(name);

            int age = 34;
            // double someNumber;
            // someNumber = 3.23123;

            // float float_var = 3.23123f;
            // bool asd = true;

            // Console.WriteLine(asd);

            // Console.WriteLine($"asdad {1 + 1}, {age}");

            SayHello();

            // def name(n)
            var multiplied = Multiply(12);
            Console.WriteLine(multiplied);

            double multiplied2 = Multiply(12.0);
            Console.WriteLine(multiplied2);

        }

        static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        static int Multiply(int n)
        {
            return n * 2;
        }
        static double Multiply(double n)
        {
            return n * 2;
        }
    }
}
