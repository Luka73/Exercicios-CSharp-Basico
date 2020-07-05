using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula04
{
    public class Desafio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 3 && n <= 20)
            {
                int t1 = 1;
                int t2 = 1;
                int t3;

                //Usando While
                Console.Write(t1 + ", ");
                Console.Write(t2 + ", ");

                int i = 3;
                while (i <= n)
                {
                    t3 = t1 + t2;
                    Console.Write(t3);
                    if (i != n) Console.Write(", ");
                    t1 = t2;
                    t2 = t3;
                    i++;
                }

                Console.WriteLine();
                Console.WriteLine("***********************");

                t1 = t2 = 1;
                Console.Write(t1 + ", ");
                Console.Write(t2 + ", ");
                //Usando For
                for (int j = 3; j <= n; j++)
                {
                    t3 = t1 + t2;
                    Console.Write(t3);
                    if (j != n) Console.Write(", ");
                    t1 = t2;
                    t2 = t3;
                }

            }
            else
            {
                Console.WriteLine("Número inválido.");
            }
            Console.ReadKey();
        } 
    }
}
