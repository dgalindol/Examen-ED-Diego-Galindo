using System;

namespace Examen_ED_Diego_Galindo
{
    public class Circle
    {
        public double Radius { get; set; }    
        public double Area { 
            get 
            {
                return (Radius * Radius) * Math.PI;
            } 
        }
    }
}
