using Shape_Master.Geometry;
using Shape_Master.Logic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shape_Master
{
    /// <summary>
    /// Фигура в 2D пространстве
    /// </summary>
    public class Shape2D : Shape
    {
        public List<double> sides { get; }
        public List<Point> points { get; }

        public Shape2D(List<double> sides)
        {
            this.sides = sides;
            this.points = null;
        }

        public Shape2D(List<Point> points)
        {
            this.points = points;
            this.sides = null;
        }

        
        public override double P()
        {
            if(sides != null)
            {
                switch (sides.Count())
                {
                    //круг
                    case 1:
                        return 2 * Math.PI * sides.ElementAt(0);

                    //прямоугольники
                    case 2:
                        return sides.Sum() * 2;

                    //остальные фигуры
                    default:
                        return sides.Sum();
                }
            } 
            else
            {
                switch (points.Count())
                {
                    //квадрат
                    case 2:
                        return MathThings.Line(points.ElementAt(0), points.ElementAt(1)) * 4;

                    //все прочие фигуры
                    default:
                        return PolygonP();
                }
            }
        }

        
        public override double S()
        {
            if (sides != null)
            {
                switch (sides.Count())
                {
                    //окружность
                    case 1:
                        return 2 * Math.PI * Math.Pow(sides.ElementAt(0), 2);

                    //прямоугольник
                    case 2:
                        return RectangleS();

                    //треугольник
                    case 3:
                        return TriangleS();

                    //прочие фигуры
                    default:
                        return PolygonS();
                }
            }
            else
            {
                switch (points.Count())
                {
                    //квадрат
                    case 2:
                        return Math.Pow(MathThings.Line(points.ElementAt(0), points.ElementAt(1)), 2);

                    //треугольник
                    case 3:
                        return TriangleS();

                    //прямоугольники
                    case 4:
                        return RectangleS();

                    //многоугольники
                    default:
                        return PolygonS();
                }
            }
        }

        public override string ToString()
        {
            string str = "shape";
            if(sides != null)
            {
                foreach(double side in sides)
                {
                    str += " " + side;
                }
            }
            else
            {
                foreach (Point p in points)
                {
                    str += " " + p.x + "," + p.y + ";";
                }
            }

            return str;
        }

        //------------------------------------------------------------------------------
        //Все вычисления вынесены сюда:
        //------------------------------------------------------------------------------

        private double TriangleS()
        {
            double a, b, c, p;
            if (points != null)
            {
                a = MathThings.Line(points.ElementAt(0), points.ElementAt(1));
                b = MathThings.Line(points.ElementAt(1), points.ElementAt(2));
                c = MathThings.Line(points.ElementAt(2), points.ElementAt(0));
            } else
            {
                a = sides.ElementAt(0);
                b = sides.ElementAt(1);
                c = sides.ElementAt(2);
            }
            p = a + b + c;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        private double RectangleS()
        {
            double a, b;
            if (points != null)
            {
                a = MathThings.Line(points.ElementAt(0), points.ElementAt(1));
                b = MathThings.Line(points.ElementAt(1), points.ElementAt(2));
            } else
            {
                a = sides.ElementAt(0);
                b = sides.ElementAt(1);
            }
            return a * b;
        }

        private double PolygonS()
        {
            double s = 0;
            if (points != null)
            {
                List<Point> l = new List<Point>();
                for (int i = 1; i < points.Count() - 1; i++)
                {
                    l.Add(points.ElementAt(0));
                    l.Add(points.ElementAt(i));
                    l.Add(points.ElementAt(i + 1));
                    s += new Shape2D(l).S();
                }
            } 
            else
            {
                //Нельзя найти площадь неправильного многоугольника 
                //по 4 сторонам
                return -42;
            }
            return s;
        }

        private double PolygonP()
        {
            double p = 0;
            for (int i = 0; i < points.Count() - 2; i++)
            {
                p += MathThings.Line(points.ElementAt(i), points.ElementAt(i + 1));
            }
            p += MathThings.Line(points.ElementAt(points.Count()), points.ElementAt(0));
            return p;
        }
    }
}