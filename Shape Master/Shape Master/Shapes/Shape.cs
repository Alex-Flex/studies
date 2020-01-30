namespace Shape_Master
{
    /// <summary>
    /// Фигуру можно создать по точкам или по отрезкам
    /// </summary>
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