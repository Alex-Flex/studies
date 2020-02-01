using Shape_Master.Logic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shape_Master
{
    /// <summary>
    /// Фигуру можно создать по точкам или по отрезкам
    /// </summary>
    public class Shape
    {
        public List<double> sides { get; }
        public List<Point> points { get; }

        public Shape(List<double> sides)
        {
            this.sides = sides;
            this.points = null;
        }

        public Shape(List<Point> points)
        {
            this.points = points;
            this.sides = null;
        }

        /// <summary>
        /// Периметр фигуры
        /// </summary>
        /// <returns>периметр</returns>
        public double P()
        {
            if(sides != null)
            {
                switch (sides.Count())
                {
                    case 1:
                        return 2 * Math.PI * sides.ElementAt(0);
                    default:
                        return sides.Sum();
                }
            } 
            else
            {
                switch (points.Count())
                {
                    case 2:
                        return Math.Pow(MathThings.Line(points.ElementAt(0), points.ElementAt(1)), 2);
                    case 3:
                        double a = MathThings.Line(points.ElementAt(0), points.ElementAt(1));
                        double b = MathThings.Line(points.ElementAt(1), points.ElementAt(2));
                        double c = MathThings.Line(points.ElementAt(2), points.ElementAt(0));
                        double p = a + b + c;
                        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                }
            }
        }

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        /// <returns>площадь</returns>
        public double S()
        {

        }
    }
}