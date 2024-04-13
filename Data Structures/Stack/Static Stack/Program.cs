using StaticStack.StaticStack;

namespace StaticStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // StaticStack first tests.
                StaticStack<int> StaticStack = new StaticStack<int>(5);

                Console.WriteLine($"Is Empty: {StaticStack.IsEmpty()}");
                Console.WriteLine($"Is Full: {StaticStack.IsFull()}");
                Console.WriteLine($"Count: {StaticStack.Count}");
                Console.WriteLine($"Maximum Size: {StaticStack.MaximumSize}");

                StaticStack.Pop();


                StaticStack.Push(5);
                StaticStack.Push(4);
                StaticStack.Push(3);
                //StaticStack.Pop();
                StaticStack.Push(2);
                StaticStack.Push(1);
                //StaticStack.Push(0);
                //StaticStack.Pop();

                StaticStack.Print();

                Console.WriteLine($"Is Empty: {StaticStack.IsEmpty()}");
                Console.WriteLine($"Is Full: {StaticStack.IsFull()}");
                Console.WriteLine($"Count: {StaticStack.Count}");
                Console.WriteLine($"Top: {StaticStack.Top()}");
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n\t{ex.Message}");
                Console.WriteLine("\n\tAborting.\n");
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}