using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Stack<T>
    {

        T[] _stack = new T[0];
        public int count { get; private set; } = 0;
        

        private void Update(int counter)
        {
            count += counter;
            Array.Resize(ref _stack, _stack.Length + counter);
        }

        public void Push(T elem)
        {
            Update(1);
            _stack[^1] = elem;
        }
        public T Pop()
        {
            T elem = _stack[^1];
            Update(-1);
            return elem;
        }
        
        public bool Contains(T elem)
        {
            return Array.Exists(_stack, i => i.Equals(elem) );
        }

        public T Peek()
        {
            return _stack[^1];
        }

        public void Log()
        {
            for(int i = 0; i < _stack.Length; i++)
            {
                Console.WriteLine(_stack[i]);
            }
        }
        
    }
}
