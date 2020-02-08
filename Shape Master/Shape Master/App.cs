using System;
using Shape_Master.Logic;
using System.Collections.Generic;

namespace Shape_Master
{
    public class App
    {
        static string command = "";                 //текст команды
        static string response = "";                //ответ, выводимый на консоль 
        Context context = new Context();     //контекст
        

        private List<ICommand> Commands = new List<ICommand>();

        public App()
        {
            Commands = new List<ICommand>() { new CommandCreateRectangle(context), new CommandEmpty(), new CommandExit(). new  };
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
            command = Console.ReadLine(); // 
            var nameCommand = command.Split(' ')[0];
            var paramsCommand = "";
            var com = Commands.Find(_ => _.Name == nameCommand);
            if (com != null)
            {
                com.Execute(paramsCommand); 
                // tr 1,2,3 
                // tr [(12,3),(15,6),(8,45)]
            }

            Console.Write(response);
        }
    }
}