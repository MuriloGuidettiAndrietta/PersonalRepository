using Stack.Constants;
using System.ComponentModel.Design.Serialization;

namespace Stack.Stack.StaticStack
{
    public class StaticStack<T> : Stack<T>
    {
        private T[] Stack;

        public int MaximumSize { get; }

        public int Count { get; private set; }

        public StaticStack(int size = StackConstants.DefaultMaximumStaticStackSize)
        {
            Stack = new T[size];
            MaximumSize = size;
            Count = 0;
        }

        public override T Top()
        {
            if (IsEmpty())
                throw new Exception();

            return Stack[Count - 1];
        }

        public override bool IsEmpty()
        {
            return Count == 0;
        }

        public override bool IsFull()
        {
            return Count == MaximumSize;
        }

        public override void Pop()
        {
            if (IsEmpty())
                throw new Exception();

            Count--;
        }

        public override void Push(T data)
        {
            if (IsFull())
                throw new Exception();

            Stack[Count] = data;
            Count++;
        }

        public override void Print()
        {
            Console.WriteLine("\t-------------------------");
            Console.WriteLine("\t Printing Stack Elements");
            Console.WriteLine("\t-------------------------");

            for(var index = Count - 1; index >= 0; index--)
                Console.WriteLine($"\t\t{Stack[index]}");

            Console.WriteLine("\t-------------------------");
        }
    }
}
