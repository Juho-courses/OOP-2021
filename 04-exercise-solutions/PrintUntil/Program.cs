using System;

namespace PrintUntil
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintUntilNum(4);
        }

        static void PrintUntilNum(int value)
        {
            if (value < 0)
            {
                Console.WriteLine("Given number too small.");
                return;
            }

            for (int i = 0; i < value + 1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
