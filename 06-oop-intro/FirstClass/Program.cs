using System;

namespace FirstClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.Greet("Juho");

        }
    }

    class MyClass
    {
        public void Greet(string str)
        {
            Console.WriteLine("Hello " + str);
        }
    }
}
