using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerccios.exercicios
{
    public static class Exercicio07_Impares
    {
        public static void Executar()
        {
            Console.WriteLine("Numeros impares");
            Console.WriteLine("------------------------");
            Console.Write("Digite um número inteiros de 1 a 1000: ");
            int numero = int.Parse(Console.ReadLine());
            while (true)
            {
                if (numero <= 0 || numero > 1000)
                {
                    Console.WriteLine("o numero precisa ser de 1 a 1000, tente novamente: ");
                }
                break;
            }
            Console.WriteLine("voce digitou: " + numero);
            for (int i = 0; i <= numero; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
