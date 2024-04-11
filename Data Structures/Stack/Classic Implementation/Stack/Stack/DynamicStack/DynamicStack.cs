namespace Stack.Stack.DynamicStack
{
    public class DynamicStack<T> : Stack<T>
    {
        private List<T> Stack;

        public int Count 
        { 
            get 
            { 
                return Stack.Count;
            } 
        }

        public DynamicStack()
        {
            Stack = new List<T>();            
        }

        public override bool IsEmpty()
        {
            return Stack.Count == 0;
        }

        public override bool IsFull()
        {
            return false;
        }

        public override T Top()
        {
            if (IsEmpty())
                throw new Exception();

            return Stack.First();
        }

        public override void Push(T data)
        {
            Stack.Insert(0, data);
        }

        public override void Pop()
        {
            if (IsEmpty())
                throw new Exception();

            Stack.RemoveAt(0);
        }

        public override void Print()
        {
            Console.WriteLine("\t-------------------------");
            Console.WriteLine("\t Printing Stack Elements");
            Console.WriteLine("\t-------------------------");

            foreach(var element in Stack)
                Console.WriteLine($"\t\t{element}");
            
            Console.WriteLine("\t-------------------------");
        }
    }
}