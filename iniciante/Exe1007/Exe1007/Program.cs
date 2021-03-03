using System;

namespace Exe1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            double diferenca = (a * b) - (c * d);
            Console.WriteLine("DIFERENCA = " + diferenca);
            Console.ReadKey();
        }
    }
}
