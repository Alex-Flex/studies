using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    /// <summary>
    /// Удаление данных о фигурах
    /// </summary>
    class CommandForget : Command
    {
        private Context context;

        public CommandForget(Context c)
        {
            this.context = c;
        }

        public override void Execute()
        {
            context.ForgetAll();
        }

        public override bool Validate()
        {
            return true;
        }
    }
}
