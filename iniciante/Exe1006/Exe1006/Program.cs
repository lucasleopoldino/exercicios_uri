using System;
using System.Globalization;

namespace Exe1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = ((a * 2) + (b * 3) + (c * 5)) / 10;
            Console.WriteLine("MEDIA = " + media.ToString("0.0") + "\n");

            Console.ReadKey();
        }
    }
}
