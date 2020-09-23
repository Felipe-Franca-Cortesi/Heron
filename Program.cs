using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Digite os lados do triângulo desejado");
            Console.Write("Lado 1..: ");
            double ladoUm = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado 2..: ");
            double ladoDois = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lado 3..: ");
            double ladoTres = Convert.ToDouble(Console.ReadLine());

            double p = (ladoUm + ladoDois + ladoTres) / 2;
            double a = Math.Sqrt(p * (p - ladoUm) * (p - ladoDois) * (p - ladoTres));
       
            
            Console.Write("\n");
            Console.WriteLine($"Semiperímetro..:{p}");
            Console.WriteLine($"Área...........:{a}");
        }
    }
}
