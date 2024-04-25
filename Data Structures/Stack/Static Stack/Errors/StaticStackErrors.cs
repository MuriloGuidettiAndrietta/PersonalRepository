namespace StaticStack.Errors
{
    public static class StaticStackErrors
    {
        // Stack Overflow Error.
        public const string StackOverflowError = "StackOverflowError: The Stack has reached the maximum number of elements. Push operations are not allowed.";

        // Stack Underflow Error.
        public const string StackUnderflowError = "StackUnderflowError: The Stack is empty. Top and Pop operations are not allowed.";

        // Invalid Stack Size Error.
        public const string InvalidStackSizeError = "InvalidStackSizeError: The Stack size must be a positive integer.";

        // Invalid Stack Operation Error.
        public const string InvalidStackOperationError = "InvalidStackOperationError: The Stack operation is invalid.";
    }
}