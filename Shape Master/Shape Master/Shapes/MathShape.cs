using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Shapes
{
    class MathShape
    {
        /// <summary>
        /// Вычисляет длину отрезка
        /// </summary>
        /// <param name="p1">точка 1</param>
        /// <param name="p2">точка 2</param>
        /// <returns>длина отрезка</returns>
        public static double Line(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }
}
