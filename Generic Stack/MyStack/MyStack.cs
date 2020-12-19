using System.Collections.Generic;

namespace Stacks.Library
{
    public class MyStack<T>
    {
        private readonly List<T> _items = new List<T>();

        public MyStack<T> Push(T item)
        {
            _items.Add(item);
            
            return this;
        }

        public T Pop()
        {
            if (_items.Count == 0)
            {
                return default;
            }
            
            var item = _items[^1];
            _items.RemoveAt(_items.Count - 1);
            
            return item;
        }
    }
}
