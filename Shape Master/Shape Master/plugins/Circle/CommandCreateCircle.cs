using Shape_Master.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.plugins.CircleCommands
{
    class CommandCreateCircle : ICommand
    {
        public string Name { get => "сircle"; }

        public bool Execute(Context context, string command)
        {
            string[] args = command.Split(" ");

            if (args.Length != 2)   //неверен синтаксис команды 
                return false;

            if (args[0] != "circle")    //запрос не на создание нужной фигуры
                return false;

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
