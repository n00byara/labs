using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Stack
    {

        int[] _quine;

        public Stack(int[] buffer) 
        {
            _quine = buffer;
        }

        private void Update()
        {
            Array.Resize(ref _quine, _quine.Length + 1);
        }

        public void Push(int number)
        {
            Update();
            _quine[^1] = number;
        }
        
        public void Log()
        {
            for(int i = 0; i < _quine.Length; i++)
            {
                Console.WriteLine(_quine[i]);
            }
        }
        
    }
}
