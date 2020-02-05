using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    class CommandNotFound : Command
    {
        public override void Execute()
        {
            Console.WriteLine(Strings.NO_SUCH_COMMAND);
        }

        public override bool Validate()
        {
            return false;
        }
    }
}
