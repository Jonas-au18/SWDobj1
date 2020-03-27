﻿namespace MementoMori
{
    public class Memento
    {
        private string _state;

        public Memento(string state)
        {
            _state = state;
        }

        public string state
        {
            get { return _state; }
        }
    }
}