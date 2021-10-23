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

            var rList = new LinkedList<T>();

            var currentNode = linkedList.First;

            if (linkedList.Count == 1)
            {
                return true;
            }

            var pointer1 = rList.First;
            var pointer2 = linkedList.First;

            while (pointer1 == pointer2)
            {
                if(pointer1 != pointer2)
                {
                    return false;
                }
                
                continue;
            }
            return true;

        }
    }
}