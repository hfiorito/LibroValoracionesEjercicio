using System;
using System.Collections.Generic;
using System.Text;

namespace LibroValoracionesEjercicio
{
    class LibroValoraciones
    {
        public List<float> valoraciones;

        public LibroValoraciones()
        {
            valoraciones = new List<float>();
        }


        public void AgregarValoracion(float valoracion)
        {
            valoraciones.Add(valoracion);
            
        }

        public List<float> OrdenarMenAMay()
        {
            
            return valoraciones.Sort();
        }
        public CalcularValoraciones PublicarValoraciones()//como voy a devolver un valor de una clase, en lugar de void va el nombre de la variable que voy a devolver, ene ste caso la clase

        {
            CalcularValoraciones calculo = new CalcularValoraciones();//creo un obj calculo de la clase CalcularValoraciones entonces luego puedo retornarlo porque es de la misma clase del método
            float sumaValoraciones = 0;//la creo porque la necesito luego para calcular el promedio. Para calcular la suma, debo leer la lista "valoraciones" y sumar todos sus valores
            foreach (float valoracion in valoraciones)
            {
                sumaValoraciones = sumaValoraciones + valoracion;
                calculo.valoracionMax = Math.Max(valoracion, calculo.valoracionMax);//calcula el máximo entre 2 valores
                calculo.valoracionMin = Math.Min(valoracion, calculo.valoracionMin);//calcula el mínimo entre 2 valores
            }

            calculo.promValoraciones = sumaValoraciones / valoraciones.Count;
            return calculo;
        }
        
    }    
}
