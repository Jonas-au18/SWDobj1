using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedWeStand
{
    class Originator
    {
        private double _value;

        public double value_
        {
            get { return _value; }
            set
            {
                value_ = value;
            }
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

