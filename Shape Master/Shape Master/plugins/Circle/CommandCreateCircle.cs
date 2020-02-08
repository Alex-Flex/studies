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

            double d;
            if(Double.TryParse(args[1], out d))
            {
                context.Add(new Circle(d), command);
                return true;
            } 

            return false;
        }
    }
}
