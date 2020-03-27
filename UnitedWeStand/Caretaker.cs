using System;
using System.Collections.Generic;

namespace UnitedWeStand
{
    public class Caretaker : ICaretaker
    {
        private List<Memento> _mementoes = new List<Memento>();

        public void add(Memento state)
        {
            _mementoes.Add(state);
        }

        public Memento get(int index)
        {
            return _mementoes[index];
        }

        public int numberOfMemntos()
        {
            return _mementoes.Count;
        }

    }
}