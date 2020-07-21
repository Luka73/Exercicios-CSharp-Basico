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
            int tamanho = arr.Length; //20
            int sum = 0; //acumulador
   
            for (int i = 0; i < arr.Length; i++) //percorrer o array TODO!
            {
                if(arr[i] % 2 == 0) //se é par
                    sum = sum + arr[i];
            }

            foreach(int j in arr) //percorrer o array TODO!
            {
                if (arr[j] % 2 == 0) //se é par
                    sum = sum + arr[j];
            }

            Console.WriteLine("Soma dos valores: " + sum);
            Console.ReadKey();
        }
    }
}
