using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    /// <summary>
    /// Вывод справки
    /// </summary>
    class CommandHelp : ICommand
    {
        public string Name { get => "CommandHelp"; }

        public bool Execute(Context c, String s)
        {
            Console.WriteLine(Strings.HELP);
            return true;
        }
    }
}
