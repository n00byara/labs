using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 1, 2, 3 };
            Stack stack = new Stack(arr);
            stack.Push(1);
            stack.Push(0);
            stack.Log();
            Console.ReadKey();
        }
    }
}
