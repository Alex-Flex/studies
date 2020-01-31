using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    class CommandCreateShape : Command
    {
        private Context context;
        private string command;
        private string parameter;

        public CommandCreateShape(Context context, string command)
        {
            this.context = context;
            this.command = command;
        }

        public override void Execute()
        {
            
        }

        public override void Parse()
        {
            
        }

        public override bool Verify()
        {
            string[] args = command.Split(' ');
            
        }
    }
}
