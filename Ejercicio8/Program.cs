using System;
using System.Collections.Generic;

namespace Ejercicio8
{
    class Program
    {
        public static List<Tarea> tareas = new List<Tarea>();
        public static List<int> dependencias = new List<int>();
        static void Main(string[] args)
        {
            int cantTareas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantTareas; i++)
            {
                string[] a = Console.ReadLine().Split(',');
                tareas.Add(new Tarea(Convert.ToInt32(a[0]), Convert.ToInt32(a[1])));
            }
        }











    }

    class Tarea
    {
        public Tarea(int tarea,int duracion) {
            this.tarea = tarea;
            this.duracion = duracion;

        }
        public int tarea { get; set; }
        public int duracion { get; set; }
    }
}
