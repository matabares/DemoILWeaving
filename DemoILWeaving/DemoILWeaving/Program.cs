using System;

namespace DemoILWeaving
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper.ALongMethod(10);
            Console.WriteLine("Hello World!");
        }
    }
}
