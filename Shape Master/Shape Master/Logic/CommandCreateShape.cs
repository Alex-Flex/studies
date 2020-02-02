using System;
using System.Collections.Generic;

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
        private string[] words;

        public CommandCreateShape(Context context, string command)
        {
            this.context = context;
            this.command = command;
            words = command.Split(" ");
        }

        /// <summary>
        /// Выполняет команду
        /// </summary>
        public override void Execute()
    {
            string[] args = command.Split(" ");
            howtocreate = args[1];
            List<double> doubles = new List<double>();
            if (howtocreate == "bypoint")
            {
                List<Point> points = new List<Point>();
                foreach(string point in words[3].Split(";"))
                {
                    foreach (string coord in point.Split(","))
                    {
                        doubles.Add(Double.Parse(coord));
                    }
                    points.Add(new Point(doubles));
                }
                context.Add(new Shape2D(points));
            }
            else
            {
                foreach (string side in words[3].Split(" "))
                {
                    doubles.Add(Double.Parse(side));
                }
                context.Add(new Shape2D(doubles));
            }
        }

        /// <summary>
        /// Проверяет правильность введённых данных
        /// </summary>
        /// <returns>Всё ок или нет?</returns>
        public override bool Validate()
        {
            //неверный способ создания фигуры
            if (words[1] != "bypoint" && words[1] != "byside") return false;

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
