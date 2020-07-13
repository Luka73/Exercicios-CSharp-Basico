using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula05
{
    public class Questao1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            // 1, 3, 5, 7, 9, 11, 13, 15, 17, 19

            int pos = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 1)
                {
                    arr[pos] = i;
                    pos++;
                    Console.WriteLine(i + " ");
                }
            }

            Console.ReadKey();
        }
    }
}
