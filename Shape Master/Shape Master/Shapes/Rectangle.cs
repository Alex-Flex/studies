using Shape_Master.Logic;

namespace Shape_Master
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
    public class Rectangle : Shape
    {
        public double a { get; }
        public double b { get; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Малая сторона</param>
        /// <param name="b">Большая сторона</param>
        public Rectangle(double a, double b){
            this.a = a;
            this.b = b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Точка 1</param>
        /// <param name="b">Точка 2</param>
        /// <param name="c">Точка 3</param>
        public Rectangle(Point a, Point b, Point c)
        {
            this.a = MathThings.Line(a, b);
            this.b = MathThings.Line(b, c);
        }

        public override double P(){
            return a*2 + b*2;
        }
        
        public override double S(){
            return a*b;
        }
    }
}