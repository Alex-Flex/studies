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
                    response = Strings.NO_SUCH_COMMAND;
                    break;

                case Command.COMMAND_CREATE:
                    c = new CommandCreateShape(context, command);
                    if (c.Validate())
                    {
                        c.Execute();
                        response = Strings.SUCCESS;
                    }
                    else
                    {
                        response = Strings.WRONG_COMMAND;
                    }
                    break;

                case Command.COMMAND_CLEAR:
                    c = new CommandForget(context);
                    response = Strings.SUCCESS;
                    break;

                case Command.COMMAND_HELP:
                    response = Strings.HELP;
                    break;

                case Command.COMMAND_EXIT:
                    c = new CommandExit();
                    break;
                case Command.COMMAND_TOTAL:
                    c = new CommandTotalize(context);
                    response = Strings.SUCCESS;
                    break;
            }
            c.Execute();
            Console.Write(response);
        }
    }
}