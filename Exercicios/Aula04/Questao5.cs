using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula04
{
    public class Questao5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            //Usando While
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("***********************");

            //Usando For
            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine(j);
            }

            Console.ReadKey();
        }
    }
}
