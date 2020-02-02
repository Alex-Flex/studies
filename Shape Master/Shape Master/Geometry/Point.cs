//просто точка, ничего лишнего
using System.Collections.Generic;
using System.Linq;

namespace Shape_Master
{
    /// <summary>
    /// Обычная точка в системе координат, листайте дальше :)
    /// </summary>
    public class Point
    {
        public double x { get; }
        public double y { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">Координата x</param>
        /// <param name="y">Координата y</param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(List<double> coordinates)
        {
            this.x = coordinates.ElementAt(0);
            this.y = coordinates.ElementAt(1);
        }

        public override string ToString()
        {
            string s = "";
            s += x + ", ";
            s += y + "; ";
            return s;
        }
    }
}