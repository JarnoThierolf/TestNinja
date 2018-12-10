using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class StackTests
    {
        Fundamentals.Stack<string> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Fundamentals.Stack<string>();
        }

        [Test]
        public void Count_StackIsEmpty_ReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Count_StackHasElements_ReturnNumberOfElements()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            Assert.That(_stack.Count, Is.EqualTo(3));
        }

        [Test]
        public void Push_ArgumentIsNull_ThrowArgumentNullException()
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidArg_AddObjectToStack()
        {
            _stack.Push("a");

            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_StackIsEmpty_ThrowInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_StackHasElements_ReturnTopElement()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            var result = _stack.Pop();

            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Pop_StackHasElements_RemoveElementFromList()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            _stack.Pop();

            Assert.That(_stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_StackIsEmpty_ThrowInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_ListHasElements_ReturnTopElement()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            var result = _stack.Peek();

            Assert.That(result, Is.EqualTo("c"));
        }

        [Test]
        public void Peek_ListHasElements_DontRemoveTopElement()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            _stack.Peek();

            Assert.That(_stack.Count, Is.EqualTo(3));
        }
    }
}
