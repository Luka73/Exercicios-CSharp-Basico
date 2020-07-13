using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula05
{
    public class Questao4
    {
        static void Main(string[] args)
        {
            double[] arr = new double[5];
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Digite a nota do aluno " + (i + 1) + ": ");
                arr[i] = double.Parse(Console.ReadLine());
                sum = sum + arr[i];
            }

            double media = sum / 5;
            int acimaDaMedia = 0;

            foreach (double d in arr)
            {
                if (d > media)
                {
                    acimaDaMedia++;
                }
            }

            Console.WriteLine("Média da turma: " + media);
            Console.WriteLine("Alunos acima da média: " + acimaDaMedia);

            Console.ReadKey();
        }
    }
}
