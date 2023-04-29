

namespace AdvRentalApp
{
    internal class BasicStack<T>
    {
        private readonly T[] _items;

        private int _curentIndex = 0;
        public BasicStack() => _items = new T[10];
        public int Count => _curentIndex    ;

        public void Push(T item) => _items[_curentIndex++] = item;
        public T Pop() => _items[--_curentIndex];
    }
}
