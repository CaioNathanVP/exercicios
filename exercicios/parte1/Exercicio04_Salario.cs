using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerccios.exercicios.parte1
{
    public static class Exercicio04_Salario
    {
        public static void Executar()
        {
            Console.WriteLine("calculadora de salario");
            Console.WriteLine("-----------------------------------------------------");
            Console.Write("identificação: ");
            string id = Console.ReadLine();
            Console.Write("numero de horas trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            Console.Write("salario (por hora trabalhada): ");
            float salarioHora = float.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("calculando");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("numero do funcionario:" + id);
            float salariototal = horasTrabalhadas * salarioHora;
            Console.WriteLine("salario : U$" + salariototal);
        }
    }
}
