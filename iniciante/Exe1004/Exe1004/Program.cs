using System;

namespace Exe1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int prod = a * b;
            Console.WriteLine("PROD = " + prod);
            Console.ReadKey();
        }
    }
}
