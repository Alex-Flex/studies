using System;
using System.Collections.Generic;

namespace Shape_Master.Logic
{
    class UsefulThings
    {
        public static double Line(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        /// <summary>
        /// Парсинг точек для создания фигуры
        /// </summary>
        /// <param name="s">2-я часть команды</param>
        /// <returns></returns>
        public static List<Point> ParsePoints(string s)
        {
            s = s.Replace("(", "").Replace(")", "");
            List<double> doubles = new List<double>();
            List<Point> result = new List<Point>();
            foreach (string s1 in s.Split("; "))
            {
                if (s1.Split(", ").Length != 2)  //мало или много чисел как параметры для создания точки
                    return null;

                foreach (string s2 in s1.Split(", "))
                {
                    double d;
                    if (Double.TryParse(s2, out d))
                    {
                        doubles.Add(d);
                    }
                    else
                    {
                        return null;   //не распознаётся число из строки
                    }
                }
                result.Add(new Point(doubles));
                doubles.Clear();
            }
            return result;
        }

        /// <summary>
        /// Парсинг отрезков для создания фигуры
        /// </summary>
        /// <param name="s">2-я часть команды</param>
        /// <returns></returns>
        public static List<double> ParseSides(string s)
        {
            List<double> doubles = new List<double>();
            if (!s.Contains(","))
            {
                double d;
                if (Double.TryParse(s, out d))
                {
                    doubles.Add(d);
                }
                else
                {
                    return null;   //не распознаётся число из строки
                }
            }
            else
            {
                foreach (string s1 in s.Split(", "))
                {
                    double d;
                    if (Double.TryParse(s1, out d))
                    {
                        doubles.Add(d);
                    }
                    else
                    {
                        return null;   //не распознаётся число из строки
                    }
                }
            }
            return doubles;
        }
    }
}
