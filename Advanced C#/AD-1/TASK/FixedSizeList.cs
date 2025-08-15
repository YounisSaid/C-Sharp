using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    public class FixedSizeList<T>
    {
        private readonly T[] _items;
        private int _count;

        public int Capacity { get; }
        public int Count => _count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("Capacity must be greater than zero.");
            Capacity = capacity;
            _items = new T[capacity];
            _count = 0;
        }

        public void Add(T item)
        {
            if (_count >= Capacity)
                throw new InvalidOperationException("Cannot add more elements: list is full.");
            _items[_count++] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _count)
                throw new IndexOutOfRangeException("Invalid index.");
            return _items[index];
        }
    }

}
