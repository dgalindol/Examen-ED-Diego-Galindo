using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_ED_Diego_Galindo
{
    /// <summary>
    /// Comprueba que los valores Width y Height sean mayores a 0
    /// </summary>
    public class Rectangle : IArea
    {
        /// <summary>
        /// Comprueba que el valor Width es superior a 0
        /// </summary>
        private static double width;
        public double Width
        {
            get => Width;
            set
            {
                if (Width < 0) throw new ArgumentException("El valor debe ser superior a 0");
                width = Width;
            }
        }

        /// <summary>
        /// Comprueba que el valor Height es superior a 0
        /// </summary>
        private static double height;
        public double Height 
        { 
            get => Height;
            set
            {
                if (Height < 0) throw new ArgumentException("El valor debe ser superior a 0");
                height = Height;
            }
        }

        public static double Area2(double ancho, double alto)
        {
            ancho = width;
            alto = height;
            double area3 = ancho * alto;
            return area3; 
        }
        /// <summary>
        /// Implementa la interfaz IArea
        /// </summary>
        public double Area => throw new NotImplementedException();

        
    }
}
