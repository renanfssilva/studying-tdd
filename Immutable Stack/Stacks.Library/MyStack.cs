using System.Collections.Generic;

namespace Stacks.Library
{
    public class MyStack<T>
    {
        public int Count { get; }
        private readonly T _item;
        private readonly MyStack<T> _previousStack;

        public MyStack()
        {
            _previousStack = null;
            Count = 0;
            _item = default;
        }
        
        private MyStack(MyStack<T> previousStack, int count, T item)
        {
            _previousStack = previousStack;
            Count = count;
            _item = item;
        }

        public T Peek()
        {
            return _item;
        }

        public MyStack<T> Pop()
        {
            return _previousStack;
        }

        public MyStack<T> Push(T item)
        {
            return new MyStack<T>(this, Count + 1, item);
        }
        
    }
}
