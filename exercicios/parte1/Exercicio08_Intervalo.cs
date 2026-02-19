using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerccios.exercicios.parte1
{
    public static class Exercicio08_Intervalo
    {
        public static void Executar()
        {
            Console.WriteLine("leitor de numeros (verifica quantos dos numero inseridos estão entre o intervalo de 10 e 20) ");
            int quantidade;
            int dentro = 0;
            int fora = 0;
            while (true)
            {
                Console.WriteLine("insira a quantidade de numeros");
                string entradas = Console.ReadLine();
                if (int.TryParse(entradas, out quantidade) && quantidade > 0)
                    break;
                Console.WriteLine("valor inserido não valido, tente novamente");
            }
            for (int i = 0; i < quantidade; i++)
            {
                float k;
                while (true)
                {
                    Console.Write("insira seu numero: ");
                    string entrada = Console.ReadLine();
                    if (float.TryParse(entrada, out k))
                        break;
                    Console.WriteLine("Valor inserido não valido");
                }
                if (k < 10 || k > 20)
                    fora++;
                else dentro++;
            }
            Console.WriteLine("numeros dentro da faixa de 10 a 20: " + dentro);
            Console.WriteLine("numeros fora da faixa: " + fora);
        }
    }
}
