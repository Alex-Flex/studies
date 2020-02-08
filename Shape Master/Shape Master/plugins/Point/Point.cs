using System.Collections.Generic;
using System.Linq;

namespace Shape_Master
{
    /// <summary>
    /// Просто точка, ничего лишнего
    /// </summary>
    public class Point
    {
        public double X { get; }

        public double Y { get; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;

        }

        public Point(List<double> doubles)
        {
            this.X = doubles.ElementAt(0);
            this.Y = doubles.ElementAt(1);
        }
    }
}