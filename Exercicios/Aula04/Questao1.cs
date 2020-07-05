using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula04
{
    public class Questao1
    {
        static void Main(string[] args)
        {

            //Usando While
            int i = 0;
            while (i <= 30)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("***********************");

            //Usando For
            for (int j = 0; j <= 30; j++)
            {
                Console.WriteLine(j);
            }
            Console.ReadKey();
        }
    }
}
