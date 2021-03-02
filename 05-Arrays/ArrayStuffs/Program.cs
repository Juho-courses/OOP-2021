using System;

namespace ArrayStuffs
{
    class Program
    {
        static void Main(string[] args)
        {
            // dotnet run -- -myarg 1 12
            // PrintArray(args);
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }

            Console.WriteLine("-------------");
            // type name = new type[size]
            int[] arrayOfInts = new int[4];

            PrintArray(arrayOfInts);

            arrayOfInts[2] = 123;
            PrintArray(arrayOfInts);

            if (arrayOfInts[2] == 123)
            {
                Console.WriteLine("third value is 123");
            }

            Console.WriteLine("-----------");
            // string[] arrayOfString = new string[2] { "hello", "world" };
            string[] arrayOfString = { "hello", "world" };
            PrintArray(arrayOfString);
            Console.WriteLine(arrayOfString.Length);

            Console.WriteLine("-----------");
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = arr1;
            PrintArray(arr1);
            arr1[0] = 6;
            PrintArray(arr2);
            arr2[1] = 123;
            PrintArray(arr1);

            Console.WriteLine("-----------");
            int[] arr3 = (int[])arr1.Clone();
            arr1[2] = 555;
            PrintArray(arr3);

            MultiplyByN(arr3);
            PrintArray(arr3);
        }

        public static void MultiplyByN(int[] arr, int n = 2)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * n;
            }
        }

        public static void PrintArray(int[] arr)
        {
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.Write(arr[i] + " ");
            // }
            // Console.WriteLine();
            Console.WriteLine(string.Join(" ", arr));
        }
        public static void PrintArray(string[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }

    }
}
