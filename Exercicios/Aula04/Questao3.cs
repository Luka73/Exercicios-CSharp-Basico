using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula04
{
    public class Questao3
    {
        static void Main(string[] args)
        {
            //Usando While
            int i = 101;
            while (i <= 110)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("***********************");

            //Usando For
            for (int j = 101; j <= 110; j++)
            {
                Console.WriteLine(j);
            }

            Console.ReadKey();
        }
    }
}
