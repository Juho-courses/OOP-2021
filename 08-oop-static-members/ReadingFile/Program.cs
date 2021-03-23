using System;
using System.IO;

namespace ReadingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("./data.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                    break;
                }
            }
        }
    }
}
