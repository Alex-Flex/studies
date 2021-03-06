﻿using Shape_Master.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.plugins.CommmandSquare
{
    class CommandCreateSquare : ICommand
    {
        public string Name { get => "square"; }

        public bool Execute(Context context, string command)
        {
            string[] args = command.Split(" ");

            if (args.Length != 2)   //неверен синтаксис команды 
                return false;

            if (args[0] != "square")    //запрос не на создание нужной фигуры
                return false;

            if (args[1].Contains("(") && args[1].Contains(")"))  //фигура задана точками
            {
                List<Point> points = UsefulThings.ParsePoints(args[1]);

                if (points == null)
                    return false;
                if (points.Count != 2) //не то количество точек получилось
                    return false;

                context.Add(new Rectangle(points), command);
                return true;
            }
            else
            {
                //фигура задана отрезками
                List<double> doubles = UsefulThings.ParseSides(args[1]);
                if (doubles == null)
                    return false;

                if (doubles.Count != 1) //не то количество сторон получилось
                    return false;

                context.Add(new Rectangle(doubles), command);
                return true;
            }
        }
    }
}
