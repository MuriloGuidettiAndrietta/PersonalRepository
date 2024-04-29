using StaticStack.StaticStack;

namespace StaticStack.UnitTests
{
    [TestFixture]
    public class StaticStackTests
    {
        private StaticStack<int> stack;

        [SetUp]
        public void Setup()
        {
            stack = new StaticStack<int>();
        }

        [Test]
        public void IsEmpty_StackIsEmpty_ReturnsTrue()
        {
            var result = stack.IsEmpty();

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        public void IsEmpty_StackIsNotEmpty_ReturnsFalse(int numberOfStackElements)
        {
            for (var element = 1; element <= numberOfStackElements; element++)
                stack.Push(element);

            var result = stack.IsEmpty();

            Assert.IsFalse(result);
        }

        [Test]
        public void IsFull_StackIsFull_ReturnsTrue()
        {
            for(var element = 1; element <= stack.MaximumSize; element++)
                stack.Push(element);

            var result = stack.IsFull();

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(9)]
        public void IsFull_StackIsNotFull_ReturnsFalse(int numberOfStackElements)
        {
            for (var element = 1; element <= numberOfStackElements; element++)
                stack.Push(element);

            var result = stack.IsFull();

            Assert.IsFalse(result);
        }

        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        public void Top_GetsTopElementFromNotEmptyStack_RetrievesElement(int numberOfStackElements)
        {
            for (var element = 1; element <= numberOfStackElements; element++)
                stack.Push(element);

            var result = stack.Top();

            Assert.That(result == numberOfStackElements);
        }

        [Test]
        public void Top_GetsTopElementFromEmptyStack_ThrowsExceptionWithUnexistingTopElementError()
        {
            Assert.That(() => stack.Top(), Throws.Exception.Message.Contains("UnexistingTopElementError"));
        }

        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        public void Push_AddsElementsToNotFullStack_CountIncreases(int numberOfStackElements)
        {
            for (var element = 1; element <= numberOfStackElements; element++)
                stack.Push(element);

            var result = stack.Count;

            Assert.That(result == numberOfStackElements);
        }

        [Test]
        public void Push_AddsElementsToFullStack_ThrowsExceptionWithStackOverflowError()
        {
            for (var element = 1; element <= stack.MaximumSize; element++)
                stack.Push(element);

            Assert.That(() => stack.Push(stack.MaximumSize + 1), Throws.Exception.Message.Contains("StackOverflowError"));
        }

        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        public void Pop_RemovesElementFromNotEmptyStack_CountDecreases(int numberOfStackElements)
        {
            for (var element = 1; element <= numberOfStackElements; element++)
                stack.Push(element);

            stack.Pop();
            var result = stack.Count;

            Assert.That(result == numberOfStackElements - 1);
        }

        [Test]
        public void Pop_RemovesElementFromEmptyStack_ThrowsExceptionWithStackUnderflowError()
        {
            Assert.That(() => stack.Pop(), Throws.Exception.Message.Contains("StackUnderflowError"));
        }
    }
}