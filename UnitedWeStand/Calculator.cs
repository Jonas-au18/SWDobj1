namespace UnitedWeStand
{
    public class Calculator
    {
        ICommand myCommand;

        public void setCommand(ICommand command)
        {
            myCommand = command;
        }

        public void onCall()
        {
            myCommand.execute();
        }
    }
}