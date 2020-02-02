using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Geometry
{
    public abstract class Shape
    {
        /// <summary>
        /// Периметр фигуры
        /// </summary>
        /// <returns>периметр</returns>
        public abstract double P();

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        /// <returns>площадь</returns>
        public abstract double S();
    }
}
