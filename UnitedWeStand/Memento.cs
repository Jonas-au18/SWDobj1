using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedWeStand
{
    public class Memento
    {
        private double _value;

        public Memento(double value)
        {
            _value = value;
        }

        public double value
        {
            get { return _value; }
        }
    }
}
