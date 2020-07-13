using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula05
{
    public class Questao7
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[6,4]; // matriz
            int lines = arr.GetLength(0); // 6
            int columns = arr.GetLength(1); // 4

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i,j] = 0;

                    if (i == 0 || i == lines - 1)
                        arr[i,j] = 1;

                    if (j == 0 || j == columns - 1)
                        arr[i,j] = 1;

                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
