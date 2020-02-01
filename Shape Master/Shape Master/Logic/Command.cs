using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    abstract class Command
    {
        public abstract bool Validate();
        public abstract void Execute();
    }
}
