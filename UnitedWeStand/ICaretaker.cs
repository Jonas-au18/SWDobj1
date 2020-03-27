namespace UnitedWeStand
{
    public interface ICaretaker
    {
        void add(Memento m);

        Memento get(int index);

        int numberOfMementos();
    }
}