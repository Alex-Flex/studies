using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    /// <summary>
    /// Выход из программы
    /// </summary>
    class CommandExit : ICommand
    {
        public string Name { get => "exit"; }

        public bool Execute(Context c, string s)
        {
            Environment.Exit(0);
            return true;
        }
    }
}
