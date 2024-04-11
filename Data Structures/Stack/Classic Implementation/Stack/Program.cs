using Stack.Stack.DynamicStack;
using Stack.Stack.StaticStack;

namespace Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // StaticStack first tests.
                StaticStack<int> StaticStack = new StaticStack<int>(5);

                Console.WriteLine($"Is Empty: {StaticStack.IsEmpty()}");
                Console.WriteLine($"Is Full: {StaticStack.IsFull()}");
                Console.WriteLine($"Count: {StaticStack.Count}");
                Console.WriteLine($"Maximum Size: {StaticStack.MaximumSize}");
                
                //StaticStack.Pop();


                StaticStack.Push(5);
                StaticStack.Push(4);
                StaticStack.Push(3);
                //StaticStack.Pop();
                StaticStack.Push(2);
                StaticStack.Push(1);
                StaticStack.Pop();

                StaticStack.Print();

                Console.WriteLine($"Is Empty: {StaticStack.IsEmpty()}");
                Console.WriteLine($"Is Full: {StaticStack.IsFull()}");
                Console.WriteLine($"Count: {StaticStack.Count}");
                Console.WriteLine($"Top: {StaticStack.Top()}");




                // DynamicStack first tests.
                DynamicStack<int> DynamicStack = new DynamicStack<int>();
                //DynamicStack.Pop();

                Console.WriteLine($"Is Empty: {DynamicStack.IsEmpty()}");
                Console.WriteLine($"Is Full: {DynamicStack.IsFull()}");
                Console.WriteLine($"Count: {DynamicStack.Count}");
                
                DynamicStack.Push(5);
                DynamicStack.Push(4);
                DynamicStack.Push(3);
                DynamicStack.Pop();
                DynamicStack.Push(2);
                DynamicStack.Push(1);
                //DynamicStack.Pop();

                DynamicStack.Print();

                Console.WriteLine($"Is Empty: {DynamicStack.IsEmpty()}");
                Console.WriteLine($"Is Full: {DynamicStack.IsFull()}");
                Console.WriteLine($"Count: {DynamicStack.Count}");
                Console.WriteLine($"Top: {DynamicStack.Top()}");
            }
            catch(Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\t{ex.Message}");
                Console.WriteLine("\n\tAborting.\n");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}