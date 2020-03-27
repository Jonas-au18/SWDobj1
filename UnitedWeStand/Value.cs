using System;

namespace UnitedWeStand
{
    public class Value
    {
        private double _value;
        private ICaretaker care;

        public double value_
        {
            get { return _value;}
            set
            {
                _value = value;
                care.add(saveStateToMemento());
            }
        }

        public Value()
        {
            care = new Caretaker();
        }


        public void adding(double a)
        {
            _value = a + double.Parse(Console.ReadLine());
        }

        public void subtract(double a)
        {
            _value = a - double.Parse(Console.ReadLine());
        }

        public void multipy(double a)
        {
            _value = a * double.Parse(Console.ReadLine());
        }

        public void divide(double a)
        {
            _value = a / double.Parse(Console.ReadLine());
        }

        public void power(double a)
        {
            double b = double.Parse(Console.ReadLine());
            _value = (Math.Pow(a,b));
        }

        public void clear()
        {
            Console.WriteLine("\n cleared value \n input new value\n");
            value_ = double.Parse(Console.ReadLine());
        }

        public void rollBack()
        {
            var index = 0;
            Console.WriteLine("Pick point of roleback \n Possible points are from 0 - " + care.numberOfMemntos());
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
                index = care.numberOfMemntos() - 1;
            }
            if (index > care.numberOfMemntos() - 1)
            {
                Console.WriteLine("Index is out of scope - setting to last memento.");
                index = care.numberOfMemntos() - 1;
            }
            Memento temp = care.get(index);
            getStateFromMemento(temp);
        }

        public Memento saveStateToMemento()
        {
            return new Memento(value_);
        }

        public void getStateFromMemento(Memento memento)
        {
            value_ = memento.value;
        }
    }
}