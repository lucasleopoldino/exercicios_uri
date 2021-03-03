using System;

namespace Exe1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split(' ');
            string[] peca2 = Console.ReadLine().Split(' ');

            int pc1Cod = Convert.ToInt32(peca1[0]);
            int pc1Num = Convert.ToInt32(peca1[1]);
            double pc1ValorUn = Convert.ToDouble(peca1[2]);
            double pc1Total = pc1Num * pc1ValorUn;

            int pc2Cod = Convert.ToInt32(peca2[0]);
            int pc2Num = Convert.ToInt32(peca2[1]);
            double pc2ValorUn = Convert.ToDouble(peca2[2]);
            double pc2Total = pc2Num * pc2ValorUn;

            double total = pc1Total + pc2Total;
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
