using StaticStack.Constants;
using StaticStack.Interfaces;
using StaticStack.Errors;

namespace StaticStack.StaticStack
{
    public class StaticStack<T> : IStaticStack<T>
    {
        #region Fields

        private T[] Stack;

        #endregion

        #region Properties

        public int MaximumSize { get; }
        public int Count { get; private set; }

        #endregion

        #region Constructors

        public StaticStack(int size = StaticStackConstants.DefaultMaximumStaticStackSize)
        {
            Stack = new T[size];
            MaximumSize = size;
            Count = 0;
        }

        #endregion

        #region Methods

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public bool IsFull()
        {
            return Count == MaximumSize;
        }

        public T Top()
        {
            if (IsEmpty())
                throw new Exception(StaticStackErrors.StackUnderflowError);

            return Stack[Count - 1];
        }

        public void Push(T data)
        {
            if (IsFull())
                throw new Exception(StaticStackErrors.StackOverflowError);

            Stack[Count] = data;
            Count++;
        }

        public void Pop()
        {
            if (IsEmpty())
                throw new Exception(StaticStackErrors.StackUnderflowError);

            Count--;
        }

        public void Print()
        {
            Console.WriteLine("\n\t\t-------------------------");
            Console.Write("\t\t      ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Stack Elements");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t-------------------------");
            
            for (var index = Count - 1; index >= 0; index--)
                Console.WriteLine($"\t\t    {Stack[index]}");        

            Console.WriteLine("\t\t-------------------------");
        }

        #endregion
    }
}