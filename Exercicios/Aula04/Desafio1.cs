using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula04
{
    public class Desafio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;

            //Usando While
            int i = 1;
            while (i <= n)
            {
                fatorial = fatorial * i;
                //fatorial *= i;
                i++;
            }

            Console.WriteLine("O fatorial de " + n + " é: " + fatorial);

            Console.WriteLine("***********************");

            //Usando For
            fatorial = 1;
            for (int j = 1; j <= n; j++)
            {
                fatorial = fatorial * j;
            }

            Console.WriteLine("O fatorial de " + n + " é: " + fatorial);

            Console.ReadKey();
        }
    }
}
