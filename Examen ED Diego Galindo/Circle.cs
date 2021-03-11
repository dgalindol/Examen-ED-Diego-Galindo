using System;

namespace Examen_ED_Diego_Galindo
{
    /// <summary>
    /// Devuelve el valor de el area del circulo a partir del radio 
    /// </summary>
    public class Circle : IArea
    {
        private double radius;
        /// <summary>
        /// Devluelve el valor de el radio
        /// </summary>
        public double Radius
        {
            get => radius;
            set
            {
                if (Radius < 0)
                {
                    throw new ArgumentException("El valor debe ser mayor que 0");
                }
            }
        }
        /// <summary>
        /// Devuelve el valor del area
        /// </summary>
        public double Area
        {
            get
            {
                return (Radius * Radius) * Math.PI;
            }
        }
        /// <summary>
        /// Devuelve el valor del radio y el area
        /// </summary>
        public string ToString(double Area)
        {
            return "Circulo de radio = " + Radius + ", área = " + Area;
        }



    }
}
