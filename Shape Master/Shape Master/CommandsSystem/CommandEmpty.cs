using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    class CommandEmpty : ICommand
    {
        public string Name { get => "CommandEmpty";  }

        public bool Execute(Context c, string s)
        {
            return true;
        }
    }
}
