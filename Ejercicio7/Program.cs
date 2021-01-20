using System;


namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string[] a = input.Split(' ');
            int cantVacas = Convert.ToInt32(a[0]);
            int camion = Convert.ToInt32(a[1]);
            string[] pesos = a[2].Split(',');
            string[] leche = a[3].Split(',');

            Console.WriteLine(MaximaProduccion(cantVacas, camion, pesos, leche, 0, 0, 0));
        }

        private static int MaximaProduccion(int cantVacas, int camion, String[] pesos, String[] leche, int i, int aLeche, int aPeso)
        {

            // Se valida si quedan vacas para procesar
            if (i < cantVacas)
            {

                // Se valida que no se supere el peso del camion
                if (aPeso + Convert.ToInt32(pesos[i]) <= camion)
                {

                    // Se devuelve el valor en mayor produccion y entre si se va a tomar la vaca o no
                    return
                        Math.Max(
                            Math.Max(
                                MaximaProduccion(cantVacas, camion, pesos, leche, i + 1, aLeche + Convert.ToInt32(leche[i]), aPeso + Convert.ToInt32(pesos[i])), aLeche),
                            Math.Max(
                                MaximaProduccion(cantVacas, camion, pesos, leche, i + 1, aLeche, aPeso), aLeche)
                            );
                }
                else
                {
                    // No se va a tomar la vaca si no cabe 
                    return MaximaProduccion(cantVacas, camion, pesos, leche, i + 1, aLeche, aPeso);
                }
            }
            return aLeche;
        }
    }
}
