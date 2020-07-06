using System;

namespace Calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cantidad de califaciones");
            int[] calificaciones = new int[Convert.ToInt32(Console.ReadLine())];

            int suma = 0;
            for(int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine("Ingrese calificaciones {0}", i);
                calificaciones[i] = Convert.ToInt32(Console.ReadLine());
                suma += calificaciones[i];
            }

            double promedio = suma / calificaciones.Length;
            Console.WriteLine("El promedio es {0}", promedio);

        }
 
    }
}
