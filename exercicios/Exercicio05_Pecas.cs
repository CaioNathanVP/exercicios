using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerccios.exercicios
{
    public static class Exercicio05_Pecas
    {
        public static void Executar()
        {
            Console.WriteLine("exercicio 5");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("peça 1 - informe: codigo, quantidade, valor respectivamente");
            string[] peca1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(peca1[0]);
            int quantidade1 = int.Parse(peca1[1]);
            decimal valor1 = decimal.Parse(peca1[2]);
            Console.WriteLine("peça 2 - informe: codigo, quantidade, valor respectivamente");
            string[] peca2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(peca2[0]);
            int quantidade2 = int.Parse(peca2[1]);
            decimal valor2 = decimal.Parse(peca2[2]);

            Console.WriteLine("valor a pagar: R$" + (valor1 * quantidade1 + valor2 * quantidade2).ToString("F2"));
        }
    }
}
