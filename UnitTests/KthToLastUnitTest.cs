using Microsoft.VisualStudio.TestTools.UnitTesting;
//using LinkedList;

namespace KthToLast
{
    [TestClass]
    public class KthToLastUnitTest
    {
        [TestMethod]
        public void SingleInt1()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i <= 40; i++)
            {
                linkedList.Append(i);
            }
            
            for (int i = 0; i <= 40; i++)
            {
                Assert.AreEqual((40 - i), linkedList.KthToLast(i));
            }
        }

        [TestMethod]
        public void DoubleInt1()
        {
            LinkedList.DoublyLinkedList<int> linkedList = new LinkedList.DoublyLinkedList<int>();
            for (int i = 0; i <= 40; i++)
            {
                linkedList.Append(i);
            }

            for (int i = 0; i <= 40; i++)
            {
                Assert.AreEqual((40 - i), linkedList.KthToLast(i));
            }
        }

        [TestMethod]
        public void SingleInt2()
        {
            LinkedList.LinkedList<int> linkedList = new LinkedList.LinkedList<int>();
            linkedList.Append(0);
            Assert.AreEqual((0), linkedList.KthToLast(0));
        }

        [TestMethod]
        public void DoubleInt2()
        {
            LinkedList.DoublyLinkedList<int> linkedList = new LinkedList.DoublyLinkedList<int>();
            linkedList.Append(0);
            Assert.AreEqual((0), linkedList.KthToLast(0));
        }

        [TestMethod]
        public void DoubleChar1()
        {
            LinkedList.DoublyLinkedList<char> linkedList = new LinkedList.DoublyLinkedList<char>();
            linkedList.Append('a');
            Assert.AreEqual(('a'), linkedList.KthToLast(0));
        }

        [TestMethod]
        public void SingleChar1()
        {
            LinkedList.LinkedList<char> linkedList = new LinkedList.LinkedList<char>();
            linkedList.Append('a');
            Assert.AreEqual(('a'), linkedList.KthToLast(0));
        }

        [TestMethod]
        public void DoubleChar2()
        {
            LinkedList.DoublyLinkedList<char> linkedList = new LinkedList.DoublyLinkedList<char>();
            for (int i = 097; i < 123; i++)
            {
                linkedList.Append((char)i);
            }

            for (int i = 097; i < 123; i++)
            {
                Assert.AreEqual((char)i, linkedList.KthToLast(122 - i));
            }
        }

        [TestMethod]
        public void SingleChar2()
        {
            LinkedList.LinkedList<char> linkedList = new LinkedList.LinkedList<char>();
            for (int i = 097; i < 123; i++)
            {
                linkedList.Append((char)i);
            }

            for (int i = 097; i < 123; i++)
            {
                Assert.AreEqual((char)i, linkedList.KthToLast(122 - i));
            }
        }

        [TestMethod]
        public void SingleString1()
        {
            LinkedList.LinkedList<string> linkedList = new LinkedList.LinkedList<string>();
            linkedList.Append("test");
            Assert.AreEqual("test", linkedList.KthToLast(0));
        }

        [TestMethod]
        public void DoubleString1()
        {
            LinkedList.DoublyLinkedList<string> linkedList = new LinkedList.DoublyLinkedList<string>();
            linkedList.Append("test");
            Assert.AreEqual("test", linkedList.KthToLast(0));
        }

        [TestMethod]
        public void SingleString2()
        {
            LinkedList.LinkedList<string> linkedList = new LinkedList.LinkedList<string>();
            for (int i = 0; i <= 40; i++)
            {
                linkedList.Append(i.ToString());
            }

            for (int i = 0; i <= 40; i++)
            {
                Assert.AreEqual((40 - i).ToString(), linkedList.KthToLast(i));
            }
        }

        [TestMethod]
        public void DoubleString2()
        {
            LinkedList.DoublyLinkedList<string> linkedList = new LinkedList.DoublyLinkedList<string>();
            for (int i = 0; i <= 40; i++)
            {
                linkedList.Append(i.ToString());
            }

            for (int i = 0; i <= 40; i++)
            {
                Assert.AreEqual((40 - i).ToString(), linkedList.KthToLast(i));
            }
        }

    }
}
