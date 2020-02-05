using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    /// <summary>
    /// Вывод справки
    /// </summary>
    class CommandHelp : Command
    {
        public override void Execute()
        {
            Console.WriteLine(Strings.HELP);
        }

        public override bool Validate()
        {
            return false;
        }
    }
}
