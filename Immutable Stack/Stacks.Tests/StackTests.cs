using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks.Library;

namespace Stacks.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void CanPushItem()
        {
            var stack = new MyStack<string>();

            var fooStack = stack.Push("foo");
            Assert.AreEqual(0, stack.Count);
            Assert.AreEqual(1, fooStack.Count);
        }
        
        [TestMethod]
        public void CanPeekItem()
        {
            var stack = new MyStack<string>();

            var fooStack = stack.Push("foo");
            Assert.AreEqual("foo", fooStack.Peek());
            Assert.AreEqual("foo", fooStack.Peek());
        }
        
        [TestMethod]
        public void CanPopOffItem()
        {
            var stack = new MyStack<string>();
            var barStack = stack.Push("foo").Push("bar");

            var fooStack = barStack.Pop();
            var emptyStack = fooStack.Pop();
            
            Assert.AreEqual(0, emptyStack.Count);
            Assert.AreEqual(1, fooStack.Count);
            Assert.AreEqual(2, barStack.Count);
        }
    }
}
