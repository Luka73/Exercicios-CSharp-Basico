using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula06
{
    public class Questao2
    {
        static void Main(string[] args)
        {
            if (ParOuImpar(6) == 1)
                Console.WriteLine("6 é par!");

            if (ParOuImpar(11) == -1)
                Console.WriteLine("11 é ímpar!");

            Console.ReadKey();
        }

        public static int ParOuImpar(int n)
        {
            return (n % 2 == 0) ? 1 : -1;
        }
    }
}
