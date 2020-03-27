using System;

namespace UnitedWeStand
{
    public class Value
    {
        private Originator _myOriginator;
        private ICaretaker care;

        public double value_
        {
            get { return _myOriginator.value_;}
            set
            {
                _myOriginator.value_ = value;
                care.add(_myOriginator.saveStateToMemento());
            }
        }

        public Value()
        {
            care = new Caretaker();
            _myOriginator = new Originator();
        }


        public void adding(double a)
        {
            value_ = a + double.Parse(Console.ReadLine());
        }

        public void subtract(double a)
        {
            value_ = a - double.Parse(Console.ReadLine());
        }

        public void multipy(double a)
        {
            value_ = a * double.Parse(Console.ReadLine());
        }

        public void divide(double a)
        {
            double b = double.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Never divide with 0!!!");
                b = 1;
            }

            value_ = a / b;
        }

        public void power(double a)
        {
            double b = double.Parse(Console.ReadLine());
            value_ = (Math.Pow(a,b));
            if (value_ > double.MaxValue)
            {
                Console.WriteLine("Thats a big number :O I cut a bit off the top.");
                value_ = double.MaxValue;
            }
        }

        public void clear()
        {
            Console.WriteLine("\n cleared value \n input new value\n");
            value_ = double.Parse(Console.ReadLine());
        }

        public void rollBack()
        {
            var index = 0;
            Console.WriteLine("Pick point of roleback \n Possible points are from 0 - " + care.numberOfMementos());
            try
            {
                index = Int32.Parse(Console.ReadLine());
                if (index.GetType() != typeof(int))
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Input must be number, index set to last memento");
                index = care.numberOfMementos() - 1;
            }
            if (index > care.numberOfMementos() - 1)
            {
                Console.WriteLine("Index is out of scope - setting to last memento.");
                index = care.numberOfMementos() - 1;
            }
            _myOriginator.getStateFromMemento(care.get(index));
        }

    }
}