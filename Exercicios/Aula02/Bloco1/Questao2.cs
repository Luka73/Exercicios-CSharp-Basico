using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula02.Bloco1
{
    public class Questao2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            int antecessor = n - 1;

            Console.WriteLine("O antecessor de " + n + " é: " + antecessor);
            Console.ReadKey();
        }
    }
}
