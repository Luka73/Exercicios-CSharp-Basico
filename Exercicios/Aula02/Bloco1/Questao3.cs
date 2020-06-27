using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula02.Bloco1
{
    public class Questao3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a base do retângulo: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo: ");
            double a = double.Parse(Console.ReadLine());

            double A = a * b;

            Console.WriteLine("A área deste retângulo é: " + A);
            Console.ReadKey();
        }
    }
}
