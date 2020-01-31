using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    abstract class Command
    {
        public abstract bool Verify();
        public abstract void Parse();
        public abstract void Execute();
    }
}
