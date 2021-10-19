using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;
using System;

namespace Palindrome
{
    [TestClass]
    public class PalindromeUnitTest
    {
        [TestMethod]
        public void OneInt()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.Append(0);
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TwoInt()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.Append(0);
            doublyLinkedList.Append(0);
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void ThreeInt()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.Append(0);
            doublyLinkedList.Append(1);
            doublyLinkedList.Append(0);
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void ManyInt()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            for (int i = -15; i < 16; i++)
            {
                doublyLinkedList.Append(Math.Abs(i));
            }
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TwoIntF()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.Append(0);
            doublyLinkedList.Append(1);
            Assert.IsFalse(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void ThreeIntF()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.Append(3);
            doublyLinkedList.Append(1);
            doublyLinkedList.Append(0);
            Assert.IsFalse(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void ManyIntF()
        {
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            for (int i = 0; i < 16; i++)
            {
                doublyLinkedList.Append(Math.Abs(i));
            }
            Assert.IsFalse(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestString1()
        {
            DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>();
            doublyLinkedList.Append("alex");
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestString2()
        {
            DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>();
            doublyLinkedList.Append("alex");
            doublyLinkedList.Append("alex");
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestString3()
        {
            DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>();
            doublyLinkedList.Append("alex");
            doublyLinkedList.Append("inner");
            doublyLinkedList.Append("alex");
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestString4()
        {
            DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>();
            for (int i = 2; i < 51; i++)
            {
                if (i % 2 == 0)
                {
                    doublyLinkedList.Append("one");
                }
                else
                {
                    doublyLinkedList.Append("two");
                }
            }
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestStringUseEqualsF1()
        {
            DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>();
            doublyLinkedList.Append("Alex");
            doublyLinkedList.Append("inner");
            doublyLinkedList.Append("alex");
            Assert.IsFalse(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestStringF2()
        {
            DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>();
            doublyLinkedList.Append("Alex");
            doublyLinkedList.Append("inner");
            doublyLinkedList.Append("tanner");
            Assert.IsFalse(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestStringF3()
        {
            DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>();
            doublyLinkedList.Append("inner");
            doublyLinkedList.Append("alex");
            Assert.IsFalse(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestStringF4()
        {
            DoublyLinkedList<String> doublyLinkedList = new DoublyLinkedList<String>();
            for (int i = 3; i < 51; i++)
            {
                if (i % 3 == 0)
                {
                    doublyLinkedList.Append("one");
                }
                else
                {
                    doublyLinkedList.Append("two");
                }
            }
            doublyLinkedList.Append("three");
            Assert.IsFalse(Program.IsPalindrome(doublyLinkedList));
        }
    }
}
