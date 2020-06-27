using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula02.Bloco2
{
    public class Questao5
    {
        static void Main(string[] args)
        {
            double horasExtra = 0;
            double valorDasHorasExtra = 0;

            Console.WriteLine("Digite o número de horas trabalhadas neste mês:  ");
            double horasTrabalhadas = double.Parse(Console.ReadLine()); //161

            Console.WriteLine("Digite o valor da hora de trabalho: ");
            double valorDaHora = double.Parse(Console.ReadLine()); //10

            if (horasTrabalhadas > 160)
            {
                horasExtra = horasTrabalhadas - 160; //1
                valorDasHorasExtra = (valorDaHora * 0.50) * horasExtra;
            }

            double salario = horasTrabalhadas * valorDaHora + valorDasHorasExtra;
            Console.WriteLine("Salário: " + salario); //1600 --> 1615
            Console.ReadKey();
        }
    }
}
