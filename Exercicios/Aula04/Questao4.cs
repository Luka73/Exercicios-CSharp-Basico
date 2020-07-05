using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula04
{
    public class Questao4
    {
        static void Main(string[] args)
        {
            //Usando While
            int i = 15;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }

            Console.WriteLine("***********************");

            //Usando o For
            for (int j = 15; j >= 1; j--)
            {
                Console.WriteLine(j);
            }

            Console.ReadKey();
        }
    }
}
