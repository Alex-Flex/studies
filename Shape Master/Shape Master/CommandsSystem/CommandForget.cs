using System;
using System.Collections.Generic;
using System.Text;

namespace Shape_Master.Logic
{
    /// <summary>
    /// Удаление данных о фигурах
    /// </summary>
    class CommandForget : ICommand
    {
        public string Name { get => "CommandForget"; }
        private Context context;

        public CommandForget(Context c)
        {
            this.context = c;
        }

        public bool Execute(Context c, string s)
        {
            context.ForgetAll();
            return true;
        }
    }
}
