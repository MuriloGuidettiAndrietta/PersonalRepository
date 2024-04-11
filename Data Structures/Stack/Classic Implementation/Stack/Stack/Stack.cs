using Stack.Interfaces;

namespace Stack.Stack
{
    public abstract class Stack<T> : IStack<T>
    {
        public virtual bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public virtual bool IsFull()
        {
            throw new NotImplementedException();
        }

        public virtual void Pop()
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            throw new NotImplementedException();
        }

        public virtual void Push(T data)
        {
            throw new NotImplementedException();
        }

        public virtual T Top()
        {
            throw new NotImplementedException();
        }
    }
}
