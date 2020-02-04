using System;
using System.Collections.Generic;
using System.Linq;

namespace Shape_Master.Logic
{
    /// <summary>
    /// Команда на создание фигуры
    /// </summary>
    class CommandCreateShape : Command
    {
        private Context context;
        private string command;
        private string howtocreate;
        private string figure;
        private string[] words;

        public CommandCreateShape(Context context, string command)
        {
            this.context = context;
            this.command = command;
            words = command.Split(" ");
            figure = words[0];
        }

        /// <summary>
        /// Выполняет команду
        /// </summary>
        public override void Execute()
        {
            howtocreate = words[1];
            List<double> doubles = new List<double>();
            List<Point> points = new List<Point>();
            if (howtocreate == "bypoint")
            {
                
                foreach(string point in words[3].Split(";"))
                {
                    foreach (string coord in point.Split(","))
                    {
                        doubles.Add(Double.Parse(coord));
                    }
                    points.Add(new Point(doubles));
                    doubles.Clear();
                }
            }
            else
            {
                foreach (string side in words[3].Split(" "))
                {
                    doubles.Add(Double.Parse(side));
                }
            }
            Shape s = null;
            switch (words[0])
            {
                case "circle":
                    s = new Circle(doubles.ElementAt(0));
                    break;
                case "rectangle":
                    _ = doubles.Count == 0 ? s = new Rectangle(points) : s = new Rectangle(doubles);
                    break;
                case "square":
                    _ = doubles.Count == 0 ? s = new Square(points) : s = new Square(doubles.ElementAt(0));
                    break;
                case "polygon":
                    s = new Polygon(points);
                    break;
                case "triangle":
                    _ = doubles.Count == 0 ? s = new Triangle(points) : s = new Triangle(doubles);
                    break;
            }
            context.Add(s);
        }

        /// <summary>
        /// Проверяет правильность введённых данных
        /// </summary>
        /// <returns>Всё ок или нет?</returns>
        public override bool Validate()
        {
            //неверный способ создания фигуры
            if (words[1] != "bypoint" && words[1] != "byside") return false;

            //создание окружности с помощью точек
            if (words[0] == "circle" && words[1] == "bypoint") return false;

            //ввод многоугольника по сторонам, так нельзя! 
            if (words[0] == "polygon" && words[1] == "byside") return false;

            return ValidateBySide();
        }

        /// <summary>
        /// Проверка на отрицательные стороны при спопобе создания "byside"
        /// </summary>
        /// <returns></returns>
        private bool ValidateBySide()
        {
            if (words[1] == "byside")
            {
                for (int i = 2; i < words.Length; i++)
                {
                    double d;
                    if (Double.TryParse(words[i], out d))
                    {
                        if (d <= 0)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
