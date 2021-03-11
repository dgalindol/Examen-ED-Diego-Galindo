using System;

namespace Examen_ED_Diego_Galindo
{
    /// <summary>
    /// Calcula el Area de un circulo a partir de un Radio dado
    /// </summary>
    public class Circle
    {
        /// <summary>
        /// Devuelve el valor del Radio
        /// </summary>
        public double Radius { get; set; }    
        /// <summary>
        /// Devuelve el valor del area del circulo calculada a traves de Radius
        /// </summary>
        public double Area { 
            get 
            {
                return (Radius * Radius) * Math.PI;
            } 
        }

        public string ToString(double Area)
        {
            return "Circulo de radio = " + Radius + ", área = " + Area;
        }



    }
}
