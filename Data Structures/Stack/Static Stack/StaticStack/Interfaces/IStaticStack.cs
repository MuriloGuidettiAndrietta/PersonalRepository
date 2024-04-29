namespace StaticStack.Interfaces
{
    public interface IStaticStack<T>
    {
        // Returns the Top element from the Stack.
        T Top();

        // Returns true if the Stack has no elements, and false, otherwise.
        bool IsEmpty();

        // Returns true if the Stack has reached the maximum number of allowed elements, and false, otherwise.
        bool IsFull();

        // Adds a new element to the top of the Stack.
        void Push(T data);

        // Removes the top element from the Stack.
        void Pop();

        // Prints all elements from the Stack.
        void Print();
    }
}