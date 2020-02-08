using Shape_Master.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.plugins.TriangleCommand
{
    class CommandCreateTriangle : ICommand
    {
        public string Name { get => "triangle"; }

        public bool Execute(Context context, string command)
        {
            string[] args = command.Split(" ");

            if (args.Length != 2)   //неверен синтаксис команды 
                return false;

            if (args[0] != "triangle")    //запрос не на создание нужной фигуры
                return false;

            List<double> doubles = new List<double>();

            if (args[1].Contains("(") && args[1].Contains(")"))  //фигура задана точками
            {
                List<Point> points = new List<Point>();
                args[1] = args[1].Replace("(", "").Replace(")", "");
                foreach (string s1 in args[1].Split(";"))
                {
                    if (s1.Split(",").Length != 2)  //мало или много чисел как параметры для создания точки
                        return false;

                    foreach (string s2 in s1.Split(","))
                    {
                        double d;
                        if (Double.TryParse(s2, out d))
                        {
                            doubles.Add(d);
                        }
                        else
                        {
                            return false;   //не распознаётся число из строки
                        }
                    }
                    points.Add(new Point(doubles));
                    doubles.Clear();
                }
                context.Add(new Triangle(points), command);
                return true;
            }
            else
            {
                //фигура задана отрезками
                foreach (string s1 in args[1].Split(", "))
                {
                    double d;
                    if (Double.TryParse(s1, out d))
                    {
                        doubles.Add(d);
                    }
                    else
                    {
                        return false;   //не распознаётся число из строки
                    }
                }
                context.Add(new Triangle(doubles), command);
                return true;
            }
        }
    }
}
