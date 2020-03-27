using System;

namespace UnitedWeStand
{
    public class Adding : ICommand
    {
        private Value _value;

        public Adding(Value val)
        {
            _value = val;
        }

        public void execute()
        {
            _value.adding(_value.value_);
        }
    }

    public class Subtract : ICommand
    {
        private Value _value;

        public Subtract(Value val)
        {
            _value = val;
        }

        public void execute()
        {
            _value.subtract(_value.value_);
        }
    }

    public class divide : ICommand
    {
        private Value _value;

        public divide(Value val)
        {
            _value = val;
        }

        public void execute()
        {
            _value.divide(_value.value_);
        }
    }

    public class multipy : ICommand
    {
        private Value _value;

        public multipy(Value val)
        {
            _value = val;
        }

        public void execute()
        {
            _value.multipy(_value.value_);
        }
    }

    public class Power : ICommand
    {
        private Value _value;

        public Power(Value val)
        {
            _value = val;
        }

        public void execute()
        {
            _value.power(_value.value_);
        }
    }

    public class Clear : ICommand
    {
        private Value _value;

        public Clear(Value val)
        {
            _value = val;
        }

        public void execute()
        {
            _value.clear();
        }
    }

    public class rollBack : ICommand
    {
        private Value _value;

        public rollBack(Value val)
        {
            _value = val;
        }

        public void execute()
        {
            _value.rollBack();
        }
    }

    public class quit : ICommand
    {
        public quit()
        {

        }

        public void execute()
        {
            Console.WriteLine("Shutting down");
        }
    }
}