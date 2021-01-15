using System;

/*
* Un entero se dice que es un palíndromo si es igual al número que se obtiene al invertir el orden de sus cifras.
* Por ejemplo, 79197 y 324423 son palíndromos. 
* 
* En esta tarea se le dará un entero N, 1 <= N <= 1.000.000 
* Usted debe encontrar el menor entero M tal que M >= N M es primo y es un palíndromo.
* 
* *Por ejemplo, si N es 31, entonces la respuesta es 101.
* 
* Formato de entrada:
* Un solo entero N, (1 <= N <= 1.000.000), en una sola línea.
* 
* Formato de salida:
* Su salida debe consistir en un solo número entero, el más pequeño palíndromo primo mayor que o igual a N.
*
*/

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Operacion(Console.ReadLine()));
        }



        public static bool Primo(int num)
        {
            int divisor = 2;
            while (divisor <= num)
            {

                if (num % divisor == 0)
                {

                    if (divisor != num)
                    {
                        return false;
                    }
                }
                divisor++;
            }
            return true;
        }
        public static string reverse(string input)
        {

            char[] chars = input.ToCharArray();

            char[] reversed = new char[chars.Length];

            for (int i = 0; i < chars.Length; i++) reversed[chars.Length - i - 1] = chars[i];

            string reversedValue = new string(reversed);

            return reversedValue;
        }
        public static bool Palindromo(string input)
        {

            if (input == reverse(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string Operacion(string input)
        {
            int num = Convert.ToInt32(input);

            if (num > 0 && num < 1000000)
            {
                for (int i = num; i <= 10000000; i++)
                {
                    if (Palindromo(i.ToString()))
                    {
                        if (Primo(i))
                        {
                            return "El resultado es:" + i;
                        }
                    }
                }
                return "No hay ningun numero que cumpla los requisitos";


            }
            else
            {
                return "Ingrese un número entre 1 y 1000000";
            }

        }
    }
}
