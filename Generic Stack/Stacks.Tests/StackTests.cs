using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks.Library;

namespace Stacks.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void CanPopOffItem()
        {
            var stack = new MyStack<string>();
            stack.Push("foo");
            Assert.AreEqual("foo", stack.Pop());
        }

        [TestMethod]
        public void CanPopOffMultipleItems()
        {
            var stack = new MyStack<string>()
                .Push("foo")
                .Push("bar");

            Assert.AreEqual("bar", stack.Pop());
            Assert.AreEqual("foo", stack.Pop());
        }

        [TestMethod]
        public void CanPopFromEmptyStack()
        {
            var stack = new MyStack<string>();
            Assert.AreEqual(null, stack.Pop());
        }
    }
}
