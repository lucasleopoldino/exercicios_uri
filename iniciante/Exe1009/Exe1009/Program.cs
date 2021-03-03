using System;

namespace Exe1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double totalVendas = double.Parse(Console.ReadLine());
            double total = salarioFixo + (totalVendas * 0.15);
            Console.WriteLine("TOTAL = R$ " + total.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
