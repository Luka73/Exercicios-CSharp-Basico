using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula05
{
    public class Questao6
    {
        static void Main(string[] args)
        {
            int[] tab = { 545, 5665, 65, 76, 12, 65 };

            int min = tab[0];
            int max = 0;

            foreach (int i in tab)
            {
                if (i > max) max = i;
                if (i < min) min = i;
            }

            Console.WriteLine("Máximo: " + max);
            Console.WriteLine("Mínimo: " + min);
            Console.ReadKey();
        }
    }
}
