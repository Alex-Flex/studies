using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    class CommandNotFound : ICommand
    {
        public string Name { get => "CommandNotFound"; }

        public bool Execute(Context c, string s)
        {
            Console.WriteLine(Strings.NO_SUCH_COMMAND);
            return true;
        }
    }
}
