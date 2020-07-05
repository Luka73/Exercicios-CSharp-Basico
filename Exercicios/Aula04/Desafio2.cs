using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula04
{
    public class Desafio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            //Usando While
            int i = 1;
            while (i <= n)
            {
                if (n % i == 0)
                { //i é divisor de n
                    count++;
                }
                i++;
            }

            if (count == 2)
            {
                Console.WriteLine(n + " é primo");
            }
            else
            {
                Console.WriteLine(n + " não é primo");
            }

            //Usando For
            count = 0;
            for (int j = 1; j <= n; j++)
            {
                if (n % j == 0)
                {
                    count++;
                }
            }

            String msg = (count == 2) ? " é primo" : " não é primo";
            Console.WriteLine(n + msg);

            Console.ReadKey();
        }
    }
}
