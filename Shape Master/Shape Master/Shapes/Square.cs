using Shape_Master.Logic;

namespace Shape_Master
{
    /// <summary>
    /// Квадрат
    /// </summary>
    public class Square : Shape
    {
        public double a { get; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">Длина одной стороны</param>
        public Square(double a){
            this.a = a;
        }

        /// <summary>
        /// Создание по точкам с любой стороны
        /// </summary>
        /// <param name="a">Точка 1</param>
        /// <param name="b">Точка 2</param>
        public Square(Point a, Point b)
        {
            this.a = MathThings.Line(a, b);
        }

        public override double P(){
            return a*4;
        }
        
        public override double S(){
            return a*a;
        }
    }
}