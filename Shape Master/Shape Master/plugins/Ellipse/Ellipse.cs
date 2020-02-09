using Shape_Master.Logic;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Shape_Master.Shapes
{
    class Ellipse : IShape
    {
        public double a { get; }
        public double b { get; }

        public Ellipse(List<Point> points)
        {
            a = UsefulThings.Line(points.ElementAt(0), points.ElementAt(1));
            b = UsefulThings.Line(points.ElementAt(0), points.ElementAt(2));
        }

        public Ellipse(List<double> doubles)
        {
            a = doubles.ElementAt(0);
            b = doubles.ElementAt(1);
        }

        public override double P()
        {
            return 2 * Math.PI * Math.Sqrt((a * a + b * b) / 2);
        }

        public override double S()
        {
            return Math.PI * a * b;
        }
    }
}
