using System;

namespace ReadingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number: ");
            string input = Console.ReadLine();
            
            Console.WriteLine(input);

            int inputInt = int.Parse(input);

            Console.WriteLine(inputInt * 2);


            Console.Write("Give a number: ");
            string input2 = Console.ReadLine();

            double inputDouble = double.Parse(input2);
            
            int d2 = (int)7.2;

            Console.WriteLine(d2);

            int sInt = 2;
            string ssInt = sInt.ToString();

            double d3 = 23.12;
            d3.ToString();
        }
    }
}
