using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula04
{
    public class Questao6
    {
        static void Main(string[] args)
        {
            //Usando While
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine("6 x " + i + " = " + (6 * i));
                i++;
            }

            Console.WriteLine("***********************");

            //Usando For
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("6 x " + j + " = " + (6 * j));
            }

            Console.ReadKey();
        }
    }
}
