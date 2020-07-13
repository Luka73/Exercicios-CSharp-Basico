using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula05
{
    public class Questao2
    {
        static void Main(string[] args)
        {
            int[] arr = { 27, 98, 19, 23, 66, 32, 71, 2, 9, 47, 31, 11, 29, 10, 17, 8, 54, 79, 5, 62 };

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("Soma dos valores: " + sum);

            Console.ReadKey();
        }
    }
}
