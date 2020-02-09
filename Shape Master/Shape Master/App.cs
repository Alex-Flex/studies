using System;
using Shape_Master.Logic;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Shape_Master
{
    public class App
    {
        private Context context = new Context();
        private List<ICommand> Commands = new List<ICommand>();

        public App()
        {
            //формируем список всех команд
            Commands = context.GetCommandList();
            Console.Beep();
        }

        public  void Run()
        {
            Console.Write(Strings.GREETING);
            while (true)
            {
                WorkWithUser();
            }
        }

        private  void WorkWithUser()
        {
            Console.Write(Strings.COMMAND_PREFIX);
            string command = Console.ReadLine();
            var nameCommand = command.Split(' ')[0];
            foreach(ICommand c in Commands)
            {
                if(c.Name == nameCommand)
                {
                    if (c.Execute(context, command))
                    {
                        Console.WriteLine(Strings.SUCCESS);
                    } 
                    else
                    {
                        Console.WriteLine(Strings.WRONG_COMMAND);
                    }
                    return;
                }
            }
            Console.WriteLine(Strings.NO_SUCH_COMMAND);
        }
    }
}