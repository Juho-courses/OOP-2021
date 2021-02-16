using System;

namespace SubstringMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string haystack = "There are Snakes on this plane";
            Console.WriteLine(HasMatch("snakes", haystack));
            Console.WriteLine(HasMatch("Snakes", haystack));
            Console.WriteLine(HasMatch("snakes2", haystack));
        }

        static bool HasMatch(string needle, string haystack)
        {

            int needlenLen = needle.Length;

            for (int i = 0; i < haystack.Length - needlenLen; i++)
            {
                string tmp = haystack.Substring(i, needlenLen);

                if (tmp.Equals(needle))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
