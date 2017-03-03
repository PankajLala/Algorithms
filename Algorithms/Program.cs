using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            IStack<int> stack = new Stack<int>(5);
            stack.Push(5);
            stack.Push(7);
            Console.WriteLine(stack.Pop());
            stack.Display();
            Console.ReadLine();
        }
    }

    public interface IStack<T>
    {
        Boolean IsEmpty();
        void Push(T item);

        T Pop();

        T Peek();

        void Display();
    }

    public class Stack<T> : IStack<T>
    {
        private T[] _items;

        private int _size, _top;

        public Stack(int size)
        {
            _size = size;
            _items = new T[_size];
            _top = -1;
        }
        public void Display()
        {
           foreach(T obj in _items)
            {
                Console.WriteLine(obj);
            }
        }

        public bool IsEmpty()
        {
            if (_top == -1)
                return true;

            return false;
        }


        public void Push(T item)
        {
            _items[++_top] = item;
        }


        T IStack<T>.Peek()
        {
            return _items[_top--];
        }

        T IStack<T>.Pop()
        {
            return _items[_top--];
        }
    }
}
