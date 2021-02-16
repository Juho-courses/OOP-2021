using System;

namespace MultiplyNine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number");

            int theNumber = int.Parse(Console.ReadLine());

            int oneLess = theNumber - 1;
            int secondNum = 9 - oneLess;

            string result = oneLess.ToString() + secondNum.ToString();

            Console.WriteLine($"{theNumber} * 9 is {result}");
        }
    }
}
