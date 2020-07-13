using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula05
{
    public class Questao8
    {
        static void Main(string[] args)
        {
            String[,] arr = new String[3,3];
            int line = arr.GetLength(0);
            int column = arr.GetLength(1);

            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i % 2 == 0)
                        arr[i,j] = (j % 2 == 0) ? "X" : "O";
                    else
                        arr[i,j] = (j % 2 == 0) ? "O" : "X";

                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
