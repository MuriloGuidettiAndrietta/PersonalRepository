namespace Palindrome.UnitTests
{
    [TestFixture]
    public class PalindromeTests
    {
        [Test]
        [TestCaseSource(nameof(PalindromeLinkedLists))]
        public void IsPalindrome_ReceivesAPalindrome_ReturnsTrue(List<string> linkedList)
        {
            var result = Palindrome.IsPalindrome(linkedList);

            Assert.IsTrue(result);
        }

        [Test]
        [TestCaseSource(nameof(NonPalindromeLinkedLists))]
        public void IsPalindrome_ReceivesANonPalindrome_ReturnsFalse(List<string> linkedList)
        {
            var result = Palindrome.IsPalindrome(linkedList);

            Assert.IsFalse(result);
        }

        [Test]
        [TestCaseSource(nameof(EmptyLinkedList))]
        public void IsPalindrome_ReceivesEmptyInput_ThrowsException(List<string> linkedList)
        {
            Assert.That(() => Palindrome.IsPalindrome(linkedList), Throws.Exception);
        }

        [Test]
        [TestCaseSource(nameof(NullLinkedList))]
        public void IsPalindrome_ReceivesNullInput_ThrowsException(List<string> linkedList)
        {
            Assert.That(() => Palindrome.IsPalindrome(linkedList), Throws.Exception);
        }
        private static List<List<string>> PalindromeLinkedLists()
        {
            var linkedLists = new List<List<string>>();

            linkedLists.Add(new List<string> { "A" });
            linkedLists.Add(new List<string> { "B", "O", "B" });
            linkedLists.Add(new List<string> { "S", "T", "A", "T", "s" });

            return linkedLists;
        }

        private static List<List<string>> NonPalindromeLinkedLists()
        {
            var linkedLists = new List<List<string>>();

            linkedLists.Add(new List<string> { "A", "B" });
            linkedLists.Add(new List<string> { "A", "B", "C" });
            linkedLists.Add(new List<string> { "A", "A", "A", "A", "B" });

            return linkedLists;
        }

        private static List<List<string>> EmptyLinkedList()
        {
            var linkedLists = new List<List<string>>();

            linkedLists.Add(new List<string>());

            return linkedLists;
        }

        private static List<List<string>> NullLinkedList()
        {
            var linkedLists = new List<List<string>>();

            linkedLists.Add(null);

            return linkedLists;
        }
    }
}