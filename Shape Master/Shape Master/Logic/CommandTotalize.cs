namespace Shape_Master.Logic
{
    class CommandTotalize : Command
    {
        private Context context;

        public CommandTotalize(Context context)
        {
            this.context = context;
        }

        public override void Execute()
        {
            context.Totalize();
        }

        public override bool Validate()
        {
            return true;
        }
    }
}
