using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;
using System;
using System.Collections.Generic;

namespace Palindrome
{
    [TestClass]
    public class PalindromeUnitTest
    {
        [TestMethod]
        public void OneInt()
        {
            LinkedList<int> doublyLinkedList = new LinkedList<int>();
            doublyLinkedList.AddLast(0);
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TwoInt()
        {
            LinkedList<int> doublyLinkedList = new LinkedList<int>();
            doublyLinkedList.AddLast(0);
            doublyLinkedList.AddLast(0);
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void ThreeInt()
        {
            LinkedList<int> doublyLinkedList = new LinkedList<int>();
            doublyLinkedList.AddLast(0);
            doublyLinkedList.AddLast(1);
            doublyLinkedList.AddLast(0);
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void ManyInt()
        {
            LinkedList<int> doublyLinkedList = new LinkedList<int>();
            for (int i = -15; i < 16; i++)
            {
                doublyLinkedList.AddLast(Math.Abs(i));
            }
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TwoIntF()
        {
            LinkedList<int> doublyLinkedList = new LinkedList<int>();
            doublyLinkedList.AddLast(0);
            doublyLinkedList.AddLast(1);
            Assert.IsFalse(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void ThreeIntF()
        {
            LinkedList<int> doublyLinkedList = new LinkedList<int>();
            doublyLinkedList.AddLast(3);
            doublyLinkedList.AddLast(1);
            doublyLinkedList.AddLast(0);
            Assert.IsFalse(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void ManyIntF()
        {
            LinkedList<int> doublyLinkedList = new LinkedList<int>();
            for (int i = 0; i < 16; i++)
            {
                doublyLinkedList.AddLast(Math.Abs(i));
            }
            Assert.IsFalse(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestString1()
        {
            LinkedList<String> doublyLinkedList = new LinkedList<String>();
            doublyLinkedList.AddLast("alex");
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestString2()
        {
            LinkedList<String> doublyLinkedList = new LinkedList<String>();
            doublyLinkedList.AddLast("alex");
            doublyLinkedList.AddLast("alex");
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestString3()
        {
            LinkedList<String> doublyLinkedList = new LinkedList<String>();
            doublyLinkedList.AddLast("alex");
            doublyLinkedList.AddLast("inner");
            doublyLinkedList.AddLast("alex");
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestString4()
        {
            LinkedList<String> doublyLinkedList = new LinkedList<String>();
            for (int i = 2; i < 51; i++)
            {
                if (i % 2 == 0)
                {
                    doublyLinkedList.AddLast("one");
                }
                else
                {
                    doublyLinkedList.AddLast("two");
                }
            }
            Assert.IsTrue(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestStringUseEqualsF1()
        {
            LinkedList<String> doublyLinkedList = new LinkedList<String>();
            doublyLinkedList.AddLast("Alex");
            doublyLinkedList.AddLast("inner");
            doublyLinkedList.AddLast("alex");
            Assert.IsFalse(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestStringF2()
        {
            LinkedList<String> doublyLinkedList = new LinkedList<String>();
            doublyLinkedList.AddLast("Alex");
            doublyLinkedList.AddLast("inner");
            doublyLinkedList.AddLast("tanner");
            Assert.IsFalse(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestStringF3()
        {
            LinkedList<String> doublyLinkedList = new LinkedList<String>();
            doublyLinkedList.AddLast("inner");
            doublyLinkedList.AddLast("alex");
            Assert.IsFalse(Program.IsPalindrome(doublyLinkedList));
        }

        [TestMethod]
        public void TestStringF4()
        {
            LinkedList<String> doublyLinkedList = new LinkedList<String>();
            for (int i = 3; i < 51; i++)
            {
                if (i % 3 == 0)
                {
                    doublyLinkedList.AddLast("one");
                }
                else
                {
                    doublyLinkedList.AddLast("two");
                }
            }
            doublyLinkedList.AddLast("three");
            Assert.IsFalse(Program.IsPalindrome(doublyLinkedList));
        }
    }
}
