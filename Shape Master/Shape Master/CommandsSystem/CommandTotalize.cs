namespace Shape_Master.Logic
{
    class CommandTotalize : ICommand
    {
        public string Name { get => "totalize"; }
        private Context context;

        public CommandTotalize(Context context)
        {
            this.context = context;
        }

        public bool Execute(Context c, string s)
        {
            context.Totalize();
            return true;
        }
    }
}
