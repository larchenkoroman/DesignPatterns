﻿namespace Memento;

public class Originator
{
    private string _state = "";
    public void SetState(string state) => _state = state;
    public string GetState() => _state;

    public Memento CreateMemento() => new Memento(_state);
    public void Restore(Memento memento)
    {
        _state = memento.GetState();
    }

    public class Memento
    {
        private readonly string _state;
        internal Memento(string state) => _state = state;
        internal string GetState() => _state;
    }
}
