using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula06
{
    public class Questao6
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = InverteArray(array1);

            foreach (int i in array1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**************************");

            foreach (int j in array2)
            {
                Console.WriteLine(j);
            }
            Console.ReadKey();
        }

        public static int[] InverteArray(int[] array)
        {
            int pos = array.Length - 1;
            int[] arrayInvertido = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                arrayInvertido[i] = array[pos];
                pos--;
            }
            return arrayInvertido;
        }
    }
}
