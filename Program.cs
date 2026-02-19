using System;
using exerccios.exercicios.NewFolder;

namespace exerccios
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== PLAYER DE EXERCÍCIOS =====");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Área do Círculo");
                Console.WriteLine("3 - Diferença");
                Console.WriteLine("4 - Salário");
                Console.WriteLine("5 - Peças");
                Console.WriteLine("6 - Duração do Jogo");
                Console.WriteLine("7 - Números Ímpares");
                Console.WriteLine("8 - Intervalo 10 a 20");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha: ");

                string opcao = Console.ReadLine();

                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        Exercicio01_Soma.Executar();
                        break;

                    case "2":
                        Exercicio02_AreaCirculo.Executar();
                        break;

                    case "3":
                        Exercicio03_Diferenca.Executar();
                        break;

                    case "4":
                        Exercicio04_Salario.Executar();
                        break;

                    case "5":
                        Exercicio05_Pecas.Executar();
                        break;

                    case "6":
                        Exercicio06_JogoDuracao.Executar();
                        break;

                    case "7":
                        Exercicio07_Impares.Executar();
                        break;

                    case "8":
                        Exercicio08_Intervalo.Executar();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para voltar ao menu...");
                Console.ReadLine();
            }
        }
    }
}
