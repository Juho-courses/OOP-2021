using System;

namespace AskUntil
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenValue = null;
            int sum = 0;
            int count = 0;
            do
            {
                Console.Write("Give an int value: ");
                givenValue = Console.ReadLine();
                if (givenValue == "-1")
                {
                    break;
                }
                sum += int.Parse(givenValue);
                count++;
            } while (true);

            Console.WriteLine(sum);

            Console.WriteLine($"avg: {(double)sum / count}");

        }
    }
}
