namespace Palindrome
{
    public class Palindrome
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n\tPalindrome\n");

                var linkedList = MockLinkedList();

                var isPalindrome = IsPalindrome(linkedList);
                if (isPalindrome)
                    Console.WriteLine("\t\tThe List is a Palindrome.");
                else
                    Console.WriteLine("\t\tThe List is not a Palindrome.");
            }
            catch (Exception exception)
            {
                Console.Error.WriteLine($"\t\t{exception.Message}");
            }
        }

        public static List<string> MockLinkedList()
        {
            try
            {
                var linkedList = new List<string>();

                linkedList.Add("B");
                linkedList.Add("O");
                linkedList.Add("B");

                return linkedList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool IsPalindrome(List<string> linkedList)
        {
            try
            {
                if (linkedList is null || !linkedList.Any())
                    throw new Exception($"{Errors.EmptyInputError}");

                var concatenatedLinkedList = new System.Text.StringBuilder(string.Empty);
                foreach (var node in linkedList)
                    concatenatedLinkedList.Append(node.ToLower()); ;

                var reversedConcatenatedLinkedList = new System.Text.StringBuilder(string.Empty);
                for (var concatenatedLinkedListIndex = concatenatedLinkedList.Length - 1; concatenatedLinkedListIndex >= 0; concatenatedLinkedListIndex--)
                    reversedConcatenatedLinkedList.Append(concatenatedLinkedList[concatenatedLinkedListIndex]);

                return concatenatedLinkedList.Equals(reversedConcatenatedLinkedList);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}