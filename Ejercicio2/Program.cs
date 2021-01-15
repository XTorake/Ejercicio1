using System;
/*
    La primera línea de la entrada da el número de casos de prueba, T. 
    Luego siguen T casos de prueba, uno por línea.
    Cada línea se compone de una cadena G en Googlerense, 
    compuesto por una o más palabras que contengan las letras de la 'a' a la 'z'. 
    Habrá exactamente un espacio entre aplabras consecutivas 
    y no habrá espacios al comienzo o al final de una línea.

 ENTRADA DE EJEMPLO
    3

    ejp mysljylc kd kxveddknmc re jsicpdrysi

    rbcpc ypc rtcsra dkh wyfrepkym veddknkmkrkcd

    de kr kd eoya kw aej tysr re ujdr lkgc jv

SALIDA DE EJEMPLO

    Case #1: our language is impossible to understand

    Caso #2: there are twenty six factorial possibilities

    Caso #3: so it is okay if you want to just give up

*/
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la cantidad de casos de uso");
            string numCasos = Console.ReadLine();
            string traducido = "";

            for (int i = 0; i < Convert.ToInt32(numCasos); i++)
            {
                Console.WriteLine("Ingresa la cadena a traducir");
                string input = Console.ReadLine();
                if (input.Length < 100)
                {
                    traducido = "Case #" + (i + 1) + ":" + Replace(input);
                }
                else
                {
                    while (input.Length > 100)
                    {
                        Console.WriteLine("La cadena no puede se mayor a 100 caracteres\n");
                        Console.WriteLine("Ingresa la cadena a traducir");
                        input = Console.ReadLine();
                    }
                    traducido = "Case #" + (i + 1) + ": " + Replace(input)+"\n";
                }

                Console.WriteLine(traducido);
            }
        }
        public static string Replace(string input)
        {
            char[] key = { 'y', 'h', 'e', 's', 'o', 'c', 'v', 'x', 'd', 'u', 'i', 'g', 'l', 'b', 'k', 'r', 'z', 't', 'n', 'w', 'j', 'p', 'f', 'm', 'a', 'q' };
            char[] abc = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            char[] cadena = input.ToCharArray();
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] != ' ')
                {
                    int index = Array.FindIndex(abc, x => x.Equals(cadena[i]));
                    cadena[i] = key[index];
                }
            }
            input = new string(cadena);
            return input;
        }
    }
}
