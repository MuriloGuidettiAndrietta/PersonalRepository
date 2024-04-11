﻿namespace Stack.Interfaces
{
    public interface IStack<T>
    {
        // Returns the Top element of the Stack.        
        T Top();

        // Returns true if the Stack has no elements, and false, otherwise.
        bool IsEmpty();

        // Returns true if the Stack has the reached the maximum number of allowed elements, and false, otherwise.
        bool IsFull();

        // Adds a new element to the top of the Stack.
        void Push(T data);

        // Removes the top element of the Stack.
        void Pop();
    }
}