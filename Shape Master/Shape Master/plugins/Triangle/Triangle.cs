using Shape_Master.Logic;
using Shape_Master.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shape_Master
{
    public class Triangle : IShape
    {
        public double A { get; }

        public double B { get; }

        public double C { get; }

        public Triangle(List<double> sides){
            A = sides.ElementAt(0);
            B = sides.ElementAt(1);
            C = sides.ElementAt(2);
        }

        public Triangle(Point a, Point b, Point c)
        {
            this.A = UsefulThings.Line(a, b);
            this.B = UsefulThings.Line(b, c);
            this.C = UsefulThings.Line(c, a);
        }

        public Triangle(List<Point> points)
        {
            A = UsefulThings.Line(points.ElementAt(0), points.ElementAt(1));
            B = UsefulThings.Line(points.ElementAt(1), points.ElementAt(2));
            C = UsefulThings.Line(points.ElementAt(2), points.ElementAt(0));
        }

        public  override double P(){
            return A + B + C;
        }
        
        public override double S(){
            var p = P() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}