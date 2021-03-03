using System;

namespace Exe1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int horasT = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine());
            double salario = valorHora * horasT;
            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
