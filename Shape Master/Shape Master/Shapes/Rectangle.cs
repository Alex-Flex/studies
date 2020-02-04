using Shape_Master.Logic;
using System.Collections.Generic;
using System.Linq;

namespace Shape_Master
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
    public class Rectangle : Shape
    {
        public List<double> sides;
        public List<Point> points;

        public Rectangle(List<double> sides)
        {
            this.sides = sides;
            points = null;
        }

        public Rectangle(List<Point> points)
        {
            this.points = points;
            sides = null;
        }

        public override double P(){
            double a, b;
            if (sides != null)
            {
                a = sides.ElementAt(0);
                b = sides.ElementAt(1);
            }
            else
            {
                a = MathThings.Line(points.ElementAt(0), points.ElementAt(1));
                b = MathThings.Line(points.ElementAt(1), points.ElementAt(2));
            }
            return a * 2 + b * 2;
        }
        
        public override double S(){
            double a, b;
            if (sides != null)
            {
                a = sides.ElementAt(0);
                b = sides.ElementAt(1);
            }
            else
            {
                a = MathThings.Line(points.ElementAt(0), points.ElementAt(1));
                b = MathThings.Line(points.ElementAt(1), points.ElementAt(2));
            }
            return a * b;
        }
    }
}