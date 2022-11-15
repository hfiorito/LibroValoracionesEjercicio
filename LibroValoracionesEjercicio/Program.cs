using System;
using System.Collections.Generic;

namespace LibroValoracionesEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            LibroValoraciones libro = new LibroValoraciones();//creo mi objeto libro tomando el molde de la clase LibroValoraciones
            for (int i = 0; i < 10; )
            {                
                Console.WriteLine("Agregar Valoracion");
                float a = float.Parse(Console.ReadLine());
                if ( a >= 0 && a <= 5)
                {
                    libro.AgregarValoracion(a);
                    i++;
                }
                else
                {
                        Console.WriteLine("El valor ingresado es erróneo, vuelva a intentarlo");
                }
            }
                        
            CalcularValoraciones publicar = libro.PublicarValoraciones();//me permite hacerlo porque dentro de LibroValoraciones ya declare un objeto de CalcularValoraciones
            Console.WriteLine("El promedio de las valoraciones es: {0}", publicar.promValoraciones);
            Console.WriteLine("El valor máximo de las valoraciones es: {0}", publicar.valoracionMax);
            Console.WriteLine("El valor mínimo de las valoraciones es: {0}", publicar.valoracionMin);
            Console.WriteLine(libro.OrdenarMenAMay());
        }
    }
}
