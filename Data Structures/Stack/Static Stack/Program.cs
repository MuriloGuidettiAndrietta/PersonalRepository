using StaticStack.Errors;
using StaticStack.StaticStack;
using Serilog;

namespace StaticStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n\tStatic Stack");
                Console.Write("\n\t\tInform the Stack size: ");
                var stackSize = Convert.ToInt32(Console.ReadLine());

                if (stackSize <= 0)
                    throw new Exception(StaticStackErrors.InvalidStackSizeError);

                StaticStack<int> staticStack = new StaticStack<int>(stackSize);
                var continueFlow = true;
                
                while(continueFlow)
                {
                    PrintMenu();

                    Console.Write("\n\t\tInform the Operation: ");
                    var stackOperation = Convert.ToInt32(Console.ReadLine());

                    switch (stackOperation)
                    {
                        case 0:
                        {
                            continueFlow = false;
                            break;
                        }
                        case 1:
                        {
                            Console.Write("\t\tInform the element to add: ");
                            var data = Convert.ToInt32(Console.ReadLine());
                            staticStack.Push(data);

                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\n\t\tThe operation was completed successfully!");
                            Console.BackgroundColor = ConsoleColor.Black;
                            
                            break;
                        }
                        case 2:
                        {
                            staticStack.Pop();

                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\n\t\tThe operation was completed successfully!");
                            Console.BackgroundColor = ConsoleColor.Black;

                            break;
                        }
                        case 3:
                        {
                            var topElement = staticStack.Top();                            

                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"\n\t\tThe Top Element is: {topElement}.");
                            Console.BackgroundColor = ConsoleColor.Black;
 
                            break;
                        }
                        case 4:
                        {
                            var isEmpty = staticStack.IsEmpty();

                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(isEmpty ? "\n\t\tYes, the Stack is empty." : "\n\t\tNo, the Stack is not empty.");
                            Console.BackgroundColor = ConsoleColor.Black;

                            break;
                        }
                        case 5:
                        {
                            var isFull = staticStack.IsFull();
                            
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(isFull ? "\n\t\tYes, the Stack is full." : "\n\t\tNo, the Stack is not full.");
                            Console.BackgroundColor = ConsoleColor.Black;

                            break;
                        }
                        case 6:
                        {
                            staticStack.Print();
                            break;
                        }
                        default:
                              throw new Exception(StaticStackErrors.InvalidStackOperationError);                         
                    }
                    if (stackOperation != 0)
                    {
                        Console.Write("\n\t\tType anything to continue....");
                        Console.ReadKey();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine();
                Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
                Log.Error($"{ex.Message}");
                Log.Information("Aborting.");
                Log.CloseAndFlush();
            }
        }

        private static void PrintMenu()
        {
            Console.Clear();

            Console.WriteLine("\n\tStatic Stack");
            Console.WriteLine("\n\t\t-----------------------------");
            Console.WriteLine("\t\t\t     Menu");
            Console.WriteLine("\t\t-----------------------------");
            Console.WriteLine("\t\t   1 - Push");
            Console.WriteLine("\t\t   2 - Pop");
            Console.WriteLine("\t\t   3 - Top");
            Console.WriteLine("\t\t   4 - Is Empty");
            Console.WriteLine("\t\t   5 - Is Full");
            Console.WriteLine("\t\t   6 - Print");
            Console.WriteLine("\n\t\t   0 - End");
            Console.WriteLine("\t\t-----------------------------");
        }
    }
}