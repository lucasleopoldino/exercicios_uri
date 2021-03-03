using System;

namespace Exe1003
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int soma = a + b;
            Console.WriteLine("SOMA = " + soma);
            Console.ReadKey();
        }
    }
}
