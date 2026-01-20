using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Serialization;
using System.Xml;

namespace exerccios
{
    class Program
    {
        static void Main(string[] args)
        {
            #region exercicios entrada e saida

            //exercicio 1

            //Console.WriteLine("soma");
            //Console.WriteLine("entrada de dados:");
            //Console.WriteLine("primeiro numero:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("segundo numero:");
            //int num2 = int.Parse(Console.ReadLine());
            //int soma = num1 + num2;
            //Console.WriteLine("a soma é igual a:" + soma + ".");

            //exercicio 2


            //float pi = (float)Math.PI;
            //Console.WriteLine("calcular area de um circulo");
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("insira o valor do raio");
            //float raio = float.Parse(Console.ReadLine());
            //float area = pi * raio * raio;
            //Console.WriteLine("a area do circulo é " + area.ToString("F4") + ".");


            //exercicio 3

            //Console.WriteLine("DIFERENCA entre produto de AB e CD");
            //Console.WriteLine("--------------------------------------------");
            //Console.WriteLine("insira o valor A");
            //float a = float.Parse(Console.ReadLine());
            //Console.WriteLine("insira o valor B");
            //float b = float.Parse(Console.ReadLine());
            //Console.WriteLine("insira o valor C"); 
            //float c = float.Parse(Console.ReadLine());
            //Console.WriteLine("insira o valor D");
            //float d = float.Parse(Console.ReadLine());
            //float diferenca = a * b - c * d;
            //Console.WriteLine("a diferença é de: " + diferenca.ToString("F3"));


            //exercicio 4 

            //Console.WriteLine("calculadora de salario");
            //Console.WriteLine("-----------------------------------------------------");
            //Console.Write("identificação: ");
            //string id = Console.ReadLine();
            //Console.Write("numero de horas trabalhadas: ");
            //int horasTrabalhadas = int.Parse(Console.ReadLine());
            //Console.Write("salario (por hora trabalhada): ");
            //float salarioHora = float.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------------------------------------");
            //Console.WriteLine("calculando");
            //Console.WriteLine("-----------------------------------------------------");
            //Console.WriteLine("numero do funcionario:" + id);
            //float salariototal = horasTrabalhadas * salarioHora;
            //Console.WriteLine("salario : U$" + salariototal);

            // exercicio 5 
            //Console.WriteLine("exercicio 5");
            //Console.WriteLine("--------------------------------------------------------------------");
            //Console.WriteLine("peça 1 - informe: codigo, quantidade, valor respectivamente");
            //string[] peca1 = Console.ReadLine().Split(' ');
            //int codigo1 = int.Parse(peca1[0]);
            //int quantidade1= int.Parse(peca1[1]);
            //decimal valor1 = decimal.Parse(peca1[2]);
            //Console.WriteLine("peça 2 - informe: codigo, quantidade, valor respectivamente");
            //string[] peca2 = Console.ReadLine().Split(' ');
            //int codigo2 = int.Parse(peca2[0]);
            //int quantidade2= int.Parse(peca2[1]);
            //decimal valor2 = decimal.Parse(peca2[2]);

            //Console.WriteLine("valor a pagar: R$" + (valor1 * quantidade1 + valor2 * quantidade2).ToString("F2"));
            #endregion

            #region if else
            //EXERCICIO 6

            //string[] valores = Console.ReadLine().Split(' ');
            //int horaInicial = int.Parse(valores[0]);
            //int horaFinal = int.Parse(valores[1]);

            //int duracao;
            //if (horaInicial < horaFinal)
            //{
            //    duracao = horaFinal - horaInicial;
            //}
            //else
            //{
            //    duracao = 24 - horaInicial + horaFinal;
            //}
            //Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

            #endregion


            #region while e for

            // exercicio 1

            //Console.WriteLine("Numeros impares");
            //Console.WriteLine("------------------------");
            //Console.Write("Digite um número inteiros de 1 a 1000: ");
            //int numero = int.Parse(Console.ReadLine());
            //while (true)
            //{
            //    if (numero <= 0 || numero >1000 )
            //    {
            //        Console.WriteLine("o numero precisa ser de 1 a 1000, tente novamente: ");
            //    }
            //    break;
            //}
            //Console.WriteLine("voce digitou: " + numero );
            //for (int i = 0; i <= numero; i++)
            //{
            //    if (i % 2 == 1 )
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // exercicio 2

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
            Console.WriteLine("numeros dentro da faixa de 10 a 20: " + dentro );
            Console.WriteLine("numeros fora da faixa: " + fora);


            #endregion




        }


    }
}
    
