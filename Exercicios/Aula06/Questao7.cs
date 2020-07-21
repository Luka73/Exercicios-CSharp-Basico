using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Aula06
{
    public class Questao7
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PadLeft(3, '*', "3945"));
            Console.WriteLine(PadRight(3, '*', "3945"));
            /*Console.WriteLine(Padding(3, '*', "3945", 1));
            Console.WriteLine(Padding(3, '*', "3945", -1));*/
            Console.ReadKey();
        }

        public static string PadLeft(int pad, char element, string text)
        {
            string newText = "";

            for (int i = 1; i <= pad; i++)
            {
                newText += element;
            }

            return newText + text;
        }

        public static string PadRight(int pad, char element, string text)
        {
            string newText = "";

            for (int i = 1; i <= pad; i++)
            {
                newText += element;
            }

            return text + newText;
        }

        /*public static string Padding(int pad, char element, string text, int side) {
            String newText = "";

            for(int i = 1; i <= pad; i++) {
                newText += element;
            }

            return (side >= 0) ? text+newText : newText+text;
        }*/
    }
}
