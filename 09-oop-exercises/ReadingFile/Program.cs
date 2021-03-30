using System;
using System.IO;
using System.Collections.Generic;

namespace ReadingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> peeps = new List<Person>();

            using (var reader = new StreamReader("./data.csv"))
            {
                int line_num = 0;
                while (!reader.EndOfStream)
                {
                    if (line_num == 0)
                    {
                        line_num++;
                        reader.ReadLine();
                        continue;
                    }
                    string line = reader.ReadLine();
                    // Console.WriteLine(line);

                    var values = line.Split(",");

                    Console.WriteLine(values[0] + "----" + values[1]);

                    string name = values[0];
                    int age = Int16.Parse(values[1]);

                    Person p = new Person(name, age);
                    // p.Print();

                    peeps.Add(p);
                    // break;
                }
            }
            Console.WriteLine("peeps count: " + peeps.Count);
        }
    }
}
