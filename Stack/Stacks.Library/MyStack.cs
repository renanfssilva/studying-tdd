using System;

namespace Stacks.Library
{
    public class MyStack
    {
        private readonly object[] _items;
        private int _currentIndex;

        public MyStack(int capacity)
        {
            _items = new object[capacity];
            _currentIndex = 0;
        }

        public void Push(object item)
        {
            _items[_currentIndex] = item ?? throw new Exception();
            _currentIndex++;
        }

        public object Pop()
        {
            if (_currentIndex == 0)
            {
                return null;
            }
            
            var item = _items[_currentIndex - 1];
            _currentIndex--;
            
            return item;
        }
    }
}
