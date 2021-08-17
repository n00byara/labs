using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(10);
            Console.WriteLine(stack.Contains(3));
            
            

            Console.ReadKey();
        }

        static void Start()
        {
            Console.WriteLine("введите очередь(стек) разделяя элементы пробелами:");
            string[] consoleWords = Console.ReadLine().Split(' ');
            
            Console.ReadKey();
        }



    }
}
