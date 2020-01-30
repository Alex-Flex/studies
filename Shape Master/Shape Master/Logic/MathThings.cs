using System;

namespace Shape_Master.Logic
{
    class MathThings
    {
        public static double Line(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }
    }
}
