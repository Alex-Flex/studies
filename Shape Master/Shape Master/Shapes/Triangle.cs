using Shape_Master.Logic;
using System;

namespace Shape_Master
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Shape
    {
        public double a { get; }
        public double b { get; }
        public double c { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Сторона 1</param>
        /// <param name="b">Сторона 2</param>
        /// <param name="c">Сторона 3</param>
        public Triangle(double a, double b, double c){
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Точка 1</param>
        /// <param name="b">Точка 2</param>
        /// <param name="c">Точка 3</param>
        public Triangle(Point a, Point b, Point c)
        {
            this.a = MathThings.Line(a, b);
            this.b = MathThings.Line(b, c);
            this.c = MathThings.Line(a, c);
        }
        
        public override double P(){
            return a+b+c;
        }
        
        public override double S(){
            double p = P() / 2;
            return Math.Sqrt(p * (p-a) * (p-b) * (p-c));
        }
    }
}