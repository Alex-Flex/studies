namespace Shape_Master
{
    public abstract class IShape
    {
        /// <summary>
        /// Периметр фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double P();

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double S();
    }
}