﻿using System;

namespace Exe1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double area = n * Math.Pow(raio, 2);
            Console.WriteLine("A=" + area.ToString("0.0000"));
            Console.ReadKey();
        }
    }
}
