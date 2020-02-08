using System;

namespace Shape_Master.Logic
{
    class MathThings
    {
        public static double Line(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }
}
