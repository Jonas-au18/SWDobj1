namespace CommanderAndConqure
{
    public class Switch
    {
        ICommand _switch;

        public void setCommand(ICommand command)
        {
            _switch = command;
        }

        public void switchFlipped()
        {
            _switch.execute();
        }
    }
}