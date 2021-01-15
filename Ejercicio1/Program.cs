using System;

namespace Ejercicio1
{
    class Program
    {
    
        static void Main(string[] args)
        {
            //Se solicita el numero de casos de prueba
            Console.WriteLine("Ingresa el numero de casos de prueba");
            string inputNumCasos = Console.ReadLine();
            int numCasos;

            // Se valida hasta que se ingrese in numero valido
            while (!Int32.TryParse(inputNumCasos, out numCasos))
            {
                Console.WriteLine("Valor incorrecto, ingreselo nuevamente");
                inputNumCasos = Console.ReadLine();

            }
            numCasos = Convert.ToInt32(inputNumCasos);


            for (int i = 0; i < numCasos; i++)
            {
                Console.WriteLine("Caso #" + (i + 1));
                //Se solicita el peso de la nieve
                Console.WriteLine("Ingresa el peso de la nieve");
                string inputPesoNieve = Console.ReadLine();
                int pesoNieve;
                while (!Int32.TryParse(inputPesoNieve, out pesoNieve))
                {
                    Console.WriteLine("Valor incorrecto, ingreselo nuevamente");
                    inputPesoNieve = Console.ReadLine();

                }
                pesoNieve = Convert.ToInt32(inputPesoNieve);


                //Se solicita el numero de palmeras

                Console.WriteLine("Ingresa el numero de palmeras");
                string inputNumPalmeras = Console.ReadLine();
                int numPalmeras;
                while (!Int32.TryParse(inputNumPalmeras, out numPalmeras))
                {
                    Console.WriteLine("Valor incorrecto, ingreselo nuevamente");
                    inputNumPalmeras = Console.ReadLine();

                }

                numPalmeras = Convert.ToInt32(inputNumPalmeras);

                resolver(pesoNieve, numPalmeras);
            }

        }
        public static void resolver(int pesoNieve, int numPalmeras)
        {
            int[] palmeras = new int[100000];
            int i = 0, j = 0, longitud = 0, contadorPalmeras = 0;
            while (numPalmeras != 0)
            {
                numPalmeras--;
                Console.WriteLine("Ingresa el peso de la palmera #" + (numPalmeras + 1));
                palmeras[j] = Convert.ToInt32(Console.ReadLine());
                //se valida que el peso de la nieve sea menor o igual a lo que aguanta la palmera
                if (palmeras[j] >= pesoNieve)
                {
                    //si es asi se agrega un contador
                    contadorPalmeras++;
                    while (contadorPalmeras > 5)
                    {

                        if (palmeras[i] >= pesoNieve) contadorPalmeras--;
                        i++;
                    }
                }

                if (longitud < (j - i + 1))
                {
                    longitud = j - i + 1;
                }

                j++;

            }
            Console.WriteLine("Longitud :" + longitud + "\n");



        }


    }
}
