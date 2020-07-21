using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula06
{
    public class Questao1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ComparaNumeros(3,4));
            Console.ReadKey();
        }

        public static int ComparaNumeros(int n1, int n2)
        {
            if (n1 < n2) return -1;
            else if (n1 == n2) return 0;
            else return 1;
        }
    }
}
