using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerccios.exercicios
{
    public static class Exercicio03_Diferenca
    {
        public static void Executar()
        {
            Console.WriteLine("DIFERENCA entre produto de AB e CD");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("insira o valor A");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("insira o valor B");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("insira o valor C");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("insira o valor D");
            float d = float.Parse(Console.ReadLine());
            float diferenca = a * b - c * d;
            Console.WriteLine("a diferença é de: " + diferenca.ToString("F3"));
        }
    }
}
