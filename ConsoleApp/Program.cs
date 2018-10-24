using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Some number");
            func(Console.ReadLine());
            Console.ReadKey();

            void func(string line)
            {
                var res = line == "42" ? "Hello, World!" : "42";
                Console.WriteLine(res);
            }
        }
    }
}
