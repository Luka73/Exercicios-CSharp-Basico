using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula04
{
    public class Questao2
    {
        static void Main(string[] args)
        {
            //Usando While incluindo -30 e 30
            int i = -30;
            while (i <= 30)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("***********************");

            //Usando While excluindo -30 e 30
            int j = -29;
            while (j < 30)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("***********************");

            //Usando For incluindo -30 e 30
            for (int x = -30; x <= 30; x++)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("***********************");

            //Usando For excluindo -30 e 30
            for (int y = -29; y < 30; y++)
            {
                Console.WriteLine(y);
            }
            Console.ReadKey();
        }
    }
}
