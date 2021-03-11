using System;

namespace Examen_ED_Diego_Galindo
{
    /// <summary>
    /// Esta clase va a calcular el Area de un circulo a partir de un Radio dado
    /// </summary>
    public class Circle
    {
        /// <summary>
        /// Esta priedad va a dar el valor del Radio del circulo
        /// /// </summary>
        public double Radius { get; set; }    
        /// <summary>
        /// Esta propiedad devuelve el valor del area del circulo calculada a traves de Radius
        /// </summary>
        public double Area { 
            get 
            {
                return (Radius * Radius) * Math.PI;
            } 
        }
    }
}
