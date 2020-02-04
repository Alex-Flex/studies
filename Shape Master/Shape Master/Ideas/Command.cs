namespace Shape_Master.Logic
{
    abstract class Command
    {
        //типы команд: создание фигуры, удаление фигур и помощь
        public const int COMMAND_UNKNOWN = 0; //неизвестная команда
        public const int COMMAND_CREATE = 1;  //создание фигуры
        public const int COMMAND_CLEAR = 2;   //удаление фигур
        public const int COMMAND_HELP = 3;    //памагити
        public const int COMMAND_EXIT = 4;    //эвакуация, так сказать
        public const int COMMAND_TOTAL = 5;   //подытоживаем наши свершения

        /// <summary>
        /// Какая это команда? Создание, удаление или вывод справки?
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public int GetType(string command)
        {
            if ((command.Contains("bypoint") || command.Contains("byside")) &&
                (command.Contains("triangle") || command.Contains("rectangle") ||
                command.Contains("circle") || command.Contains("square") || command.Contains("polygon")))
            {
                return COMMAND_CREATE;
            } 
            if (command.Contains("clear"))
            {
                return COMMAND_CLEAR;
            }
            if (command.Contains("help"))
            {
                return COMMAND_HELP;
            }
            if (command.Contains("exit"))
            {
                return COMMAND_EXIT;
            }
            if (command.Contains("totalize"))
            {
                return COMMAND_TOTAL;
            }
            return 0;
        }
        public abstract void Execute();
        public abstract bool Validate();
    }
}
