using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = 5;
            // i++ == i = i + 1
            // for (init ; condition ; growing )
            // for i in range(0, end):
            for (int i = 0; i < end; i++) {
                Console.WriteLine(i);
            }

            int rounds = 0;
            while (rounds < 0) {
                Console.WriteLine("while " + rounds.ToString());
                rounds++; // round = rounds + 1
            }
            Console.WriteLine("after while");

            rounds = 0;
            do {
                Console.WriteLine("do-while " + rounds.ToString());
                rounds++;
            } while (rounds < 0);

            
        }
    }
}
