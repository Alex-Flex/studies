using System;

namespace Shape_Master
{
    /// <summary>
    /// Окружность
    /// </summary>
    public class Circle : Shape
    {
        public double r { get; }

        /// <summary>
        /// Создание окружности по радиусу
        /// </summary>
        /// <param name="r">Радиус</param>
        public Circle(double r){
            this.r = r;
        }
        
        public override double P(){
            return 2*Math.PI*r;
        }
        
        public override double S(){
            return 2*Math.PI*r*r;
        }
    }
}