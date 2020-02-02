using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    class CommandEmpty : Command
    {
        public override void Execute()
        {
        }

        public override bool Validate()
        {
            return true;
        }
    }
}
