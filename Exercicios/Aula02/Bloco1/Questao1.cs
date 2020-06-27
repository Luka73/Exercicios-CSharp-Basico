using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula02.Bloco1
{
    public class Questao1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine("A soma é: " + soma);
            Console.ReadKey();
        }
    }
}
