namespace CommanderAndConqure
{
    public class offCommand : ICommand
    {
        private Power _power;

        public offCommand(Power pow)
        {
            _power = pow;
        }

        public void execute()
        {
            _power.off();
        }
    }
}