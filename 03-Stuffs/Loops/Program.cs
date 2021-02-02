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
            for (int i = 0; i < end; i++)
            {
                Console.WriteLine(i);
            }

            int rounds = 0;
            while (rounds < 0)
            {
                Console.WriteLine("while " + rounds.ToString());
                rounds++; // round = rounds + 1
            }
            Console.WriteLine("after while");

            rounds = 0;
            do
            {
                Console.WriteLine("do-while " + rounds.ToString());
                rounds++;
            } while (rounds < 0);

            // Find out a file name that does not yet exist 
            // so that we can write some stuff into it. 
            // This can be used to for example write some logs, 
            // debug information or whatever in a situation where 
            // whe need to make sure that we will not overwrite any old file.
            // Example credits goes to Jarkko Linnanvirta

            string file_name = "";

            int number = 0;

            do
            {
                number++;

                file_name = "log_file_" + number + ".txt";

            } while (System.IO.File.Exists(file_name));



            // Now we have a file name that does not exist. Do whatever file content writing here.....

            Console.WriteLine(file_name);
        }
    }
}
