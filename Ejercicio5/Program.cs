using System;
using System.Collections.Generic;

namespace Ejercicio5
{
    class Program
    {
        static string[] Morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
        static char[] abc = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        static void Main(string[] args)
        {

            getCode(Console.ReadLine());
        }

        static void getCode(string input)
        {
            string codigo = "";
            char[] cadena = input.ToCharArray();
            int index;
            for (int i = 0; i < cadena.Length; i++)
            {
                index = Array.FindIndex(abc, x => x.Equals(cadena[i]));
                codigo += Morse[index];

            }
            Console.WriteLine(codigo);

        }
        static void getMatches(string codigo)
        {
            List<string> resultados = new List<string>();
            int i = 0;
            int j = 1;
            string currentCode;
            
            while (i < 5)
            {
                currentCode = codigo.Substring(0, j);

                i++;
            }

            


            currentCode = codigo.Substring(0, 4);

            string[] resultado = Array.FindAll(Morse, x => x == codigo);
            Console.WriteLine("Matches");



            foreach (var item in resultado)
            {
                Console.WriteLine(item);
            }

        }




    }
}
