//просто точка, ничего лишнего
using System.Collections.Generic;

namespace Shape_Master
{
    public class Point
    {
        public double X { get; }

        public double Y { get; }

        public List<double> coordinates { get; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;

        }

        public Point(List<double> doubles)
        {
            this.coordinates = doubles;
        }
    }
}