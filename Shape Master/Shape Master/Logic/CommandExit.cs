using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    /// <summary>
    /// Выход из программы
    /// </summary>
    class CommandExit : Command
    {
        public override void Execute()
        {
            Environment.Exit(0);
        }

        public override bool Validate()
        {
            return true;
        }
    }
}
