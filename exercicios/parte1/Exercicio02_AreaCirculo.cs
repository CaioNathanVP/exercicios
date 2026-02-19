using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerccios.exercicios.parte1
{
    public static class Exercicio02_AreaCirculo
    {
        public static void Executar()
        {
            float pi = (float)Math.PI;
            Console.WriteLine("calcular area de um circulo");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("insira o valor do raio");
            float raio = float.Parse(Console.ReadLine());
            float area = pi * raio * raio;
            Console.WriteLine("a area do circulo é " + area.ToString("F4") + ".");
        }
    }
}
