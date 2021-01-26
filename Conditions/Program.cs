using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            if (num == 1)
            {
                Console.WriteLine("1");
            }
            // elif in python
            else if (num == 2)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("some number");
            }

            if (num != 4)
            {
                Console.WriteLine("not four");
            }

            // bool a = false;
            // bool b = false;

            // // and == &&
            // if (a == true && b == true) {
            //     Console.WriteLine("both are true");
            // }

            // // or == ||
            // if (a == true || b == true) { // jompikumpi
            //     Console.WriteLine("either one is true");
            // }
        }
    }
}
