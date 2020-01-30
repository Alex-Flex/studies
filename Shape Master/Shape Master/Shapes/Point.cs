//просто точка, ничего лишнего
namespace Shape_Master
{
    /// <summary>
    /// Обычная точка в системе координат, листайте дальше :)
    /// </summary>
    public class Point
    {
        public double x { get; }
        public double y { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">Координата x</param>
        /// <param name="y">Координата y</param>
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}