using Shape_Master.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shape_Master
{
    /// <summary>
    /// 
    /// </summary>
    public class Polygon : Shape
    {
        //точки
        private List<Point> _points;
        public Polygon(List<Point> points)
        {
            this._points = points;
        }

        public override double P()
        {
            var p = 0.0;
            for (var i = 0; i < _points.Count - 1; i++)
            {
                p += MathShape.Line(_points[i], _points[i+1] );
            }
            p += MathShape.Line(_points[0], _points[_points.Count-1]);
            return p;
        }

        public override double S()
        {
            var s = 0.0;
            for (var i = 1; i < _points.Count -1; i++ )
            {
                s += new Triangle(_points[0], _points[i], _points[i + 1]).S();
            }
            return s;
        }
    }
}