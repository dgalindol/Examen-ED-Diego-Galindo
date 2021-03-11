using System;

namespace Examen_ED_Diego_Galindo
{
    public class Circle
    {
        private double radius;

        public double Radius { get => radius;
            set
            {
                if (Radius < 0)
                {
                    throw new ArgumentException("El valor debe ser mayor que 0");
                }
            }
        }
        public double Area
        {
            get
            {
                return (Radius * Radius) * Math.PI;
            }
        }
    }
}
