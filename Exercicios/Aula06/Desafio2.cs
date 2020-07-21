using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula06
{
    public class Desafio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EPalindromo("ARARA"));
            Console.ReadKey();
        }

        public static bool EPalindromo(String value)
        {
            int j = value.Length - 1;
            int count = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if (value.ElementAt(i) == value.ElementAt(j))
                {
                    count++;
                }
                j--;
            }

            return count == value.Length;
        }
    }
}
