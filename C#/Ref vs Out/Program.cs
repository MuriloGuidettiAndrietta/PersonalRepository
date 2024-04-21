namespace RefvsOut
{
    public class Program
    {
        private static void RegularMethod(int number)
        {
            number++;
        }

        private static void RefMethod(ref int number)
        {
            number++;
        }

        private static void OutMethod(out int number)
        {
            number = 0;
            number++;
        }

        public static void Main(string[] args)
        {
            int number = 0;

            Console.WriteLine("\n\tRef vs Out");
            Console.WriteLine($"\n\t\tNumber value originally: {number}");
            RegularMethod(number);
            Console.WriteLine($"\t\tNumber value after RegularMethod: {number}");
            RefMethod(ref number);
            Console.WriteLine($"\t\tNumber value after RefMethod: {number}");        
            OutMethod(out number);
            Console.WriteLine($"\t\tNumber value after OutMethod: {number} (needs reinitialization out there in the OutMethod)");
        }
    }
}