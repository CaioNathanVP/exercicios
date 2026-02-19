using System;

namespace exerccios.exercicios.parte1
{
    public static class Exercicio01_Soma
    {
        public static void Executar()
        {
            Console.WriteLine("SOMA");
            Console.Write("Primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;
            Console.WriteLine("Resultado: " + soma);
        }
    }
}
