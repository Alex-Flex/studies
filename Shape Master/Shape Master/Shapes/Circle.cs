using System;

namespace Shape_Master
{
    public class Circle : Shape
    {
        private double r;
        
        public Circle(double r){
            this.r = r;
        }

        public override double P(){
            return 2*Math.PI*r;
        }
        
        public override double S(){
            return 2*Math.PI*r*r;
        }
    }
}