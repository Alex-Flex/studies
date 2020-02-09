using Shape_Master.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.plugins.Polygon
{
    class CommandCreatePolygon : ICommand
    {
        public string Name { get => "polygon"; }

        public bool Execute(Context context, string command)
        {
            string[] args = command.Split(" ");

            if (args.Length != 2)   //неверен синтаксис команды 
                return false;

            if (args[0] != "polygon")    //запрос не на создание нужной фигуры
                return false;

            if (args[1].Contains("(") && args[1].Contains(")"))  //фигура задана точками
            {
                List<Point> points = UsefulThings.ParsePoints(args[1]);

                if (points == null)
                    return false;
                if (points.Count == 0) //не то количество точек получилось
                    return false;

                context.Add(new Rectangle(points), command);
                return true;
            }
            return false;
        }
    }
}
