using System;

namespace MultiplyWithoutOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(4, 9));
        }

        static int Multiply(int a, int b)
        {
            int ret = 0;

            // 2 * 3 == 3 + 3 == 2 + 2 + 2
            for (int i = 0; i < a; i++)
            {
                ret += b;
            }

            return ret;

        }
    }
}
