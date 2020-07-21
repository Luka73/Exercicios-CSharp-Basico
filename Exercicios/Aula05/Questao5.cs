using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula05
{
    public class Questao5
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2,2];
            //int[][] arr1 = { {2,5}, {14,7} };
            arr[0,0] = 2;
            arr[0,1] = 5;
            arr[1,0] = 14;
            arr[1,1] = 7;

            /*Console.WriteLine(arr[0,0]);
            Console.WriteLine(arr[0,1]);
            Console.WriteLine(arr[1,0]);
            Console.WriteLine(arr[1,1]);*/

            int count = 0;
            for (int i = 0; i < arr.Length; i++) //percorre as linhas
            {
                for (int j = 0; j < arr.Length; j++) //percorre as colunas
                {
                    if (arr[i,j] > 10) //i = 1, j = 1 --> arr[i,j] = 7
                    {
                        count++; //1
                    }
                }
            }

            //Console.WriteLine(arr.Length);
            Console.WriteLine("Valores maiores que 10: " + count); //1
            Console.ReadKey();
        }
    }
}
