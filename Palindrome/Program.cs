using System;
using System.Collections.Generic;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LinkedList<int> doublyLinkedList = new LinkedList<int>();
            for (int i = -15; i < 16; i++)
            {
                doublyLinkedList.AddLast(Math.Abs(i));
            }
            IsPalindrome(doublyLinkedList);
        }

        public static bool IsPalindrome<T>(LinkedList<T> linkedList)
        {

            if (linkedList.Count == 1)
            {
                return true;
            }
            
            var rList = new LinkedList<T>();

            foreach (T x in linkedList)
            {
                rList.AddFirst(x);
            }

            LinkedListNode<T> temp1 = linkedList.First;
            LinkedListNode<T> temp2 = rList.First;

            while (temp1 != null && temp2 != null)
            {
                if (temp1.Value.Equals(temp2.Value))
                {
                    temp1 = temp1.Next;
                    temp2 = temp2.Next;

                }
                else
                {
                    return false;
                }
            }

            if (temp1 == null && temp2 == null)
                return true;

            return false;

        }
    }
}