using Shape_Master.Logic;
using System.Collections.Generic;
using System.Linq;

namespace Shape_Master
{
   /// <summary>
   /// Просто квадрат
   /// </summary>
    public class Square : IShape
    {
        public double side;
        
        public Square(List<Point> points){
            side = MathThings.Line(points.ElementAt(0), points.ElementAt(1));
        }

        public Square(double side)
        {
            this.side = side;
        }

        public override double P(){
            return side*4;
        }
        
        public override double S(){
            return side*side;
        }
    }
}