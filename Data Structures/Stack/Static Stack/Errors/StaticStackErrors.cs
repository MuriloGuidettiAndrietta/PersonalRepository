﻿namespace StaticStack.Errors
{
    public class StaticStackErrors
    {
        // Stack Overflow Error.
        public const string StackOverflowError = "The Stack has reached the maximum number of elements. The Push operation is not allowed.";

        // Stack Underflow Error.
        public const string StackUnderflowError = "The Stack is empty. The Top and Pop operations are not allowed.";
    }
}