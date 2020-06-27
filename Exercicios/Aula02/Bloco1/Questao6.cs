using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula02.Bloco1
{
    public class Questao6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            double f = double.Parse(Console.ReadLine());

            double c = (f - 32) * (5.0 / 9);

            Console.WriteLine("A temperatura em Celsius é: " + c);
            Console.ReadKey();
        }
    }
}
