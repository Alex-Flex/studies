using System;
using Shape_Master.Logic;

namespace Shape_Master
{
    public class App
    {
        static string command = "";                 //текст команды
        static string response = "";                //ответ, выводимый на консоль 
        static Context context = new Context();     //контекст
        static Command c = new CommandEmpty();      //команда

        public static void Run()
        {
            Console.Write(Strings.GREETING);
            while (true)
            {
                WorkWithUser();
            }
        }

        private static void WorkWithUser()
        {
            Console.Write(Strings.COMMAND_PREFIX);
            command = Console.ReadLine();
            switch (c.GetType(command))
            {
                case Command.COMMAND_UNKNOWN:
                    c = new CommandNotFound();
                    break;

                case Command.COMMAND_CREATE:
                    c = new CommandCreateShape(context, command);
                    break;

                case Command.COMMAND_CLEAR:
                    c = new CommandForget(context);
                    break;

                case Command.COMMAND_HELP:
                    c = new CommandHelp();
                    break;

                case Command.COMMAND_EXIT:
                    c = new CommandExit();
                    break;

                case Command.COMMAND_TOTAL:
                    c = new CommandTotalize(context);
                    break;
            }
           // try { 
                c.Execute();
            //}
            //catch (Exception)
            //{
            //    response = Strings.WRONG_COMMAND;
            //}
            Console.Write(response);
        }
    }
}