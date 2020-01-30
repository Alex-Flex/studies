using Shape_Master.Logic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shape_Master
{
    /// <summary>
    /// Многоугольник
    /// </summary>
    public class Polygon : Shape
    {
        //точки
        public List<Point> _points { get;  }

        /// <summary>
        /// Создаёт многоугольник по точкам
        /// </summary>
        /// <param name="points">Массив точек, из которых состоит многоугольник</param>
        public Polygon(List<Point> points)
        {
            this._points = points;
        }
        
        public override double P()
        {
            double p = 0;
            for(int i = 0; i < _points.Count()-2; i++)
            {
                p += MathThings.Line(_points.ElementAt(i), _points.ElementAt(i + 1));
            }
            p += MathThings.Line(_points.ElementAt(_points.Count()), _points.ElementAt(0));
            return p;
        }

        public override double S()
        {
            //стороны треугольника
            double s = 0;
            for(int i = 1; i < _points.Count()-1; i++)
            {
                s += new Triangle(_points.ElementAt(0), _points.ElementAt(i), _points.ElementAt(i + 1)).P();
            }

            return s;
        }
    }
}