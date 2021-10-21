using System;
namespace PracticeExercise3
{

    public class DoublyLinkedListNode<T>
    {
        public T Data { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Prev { get; set; }

        public DoublyLinkedListNode(T data = default(T), DoublyLinkedListNode<T> prev = null, DoublyLinkedListNode < T> next = null)
        {
            Data = data;
            Prev = prev;
            Next = next;

        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }

    public class DoublyLinkedList<T>: IList<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }

        public DoublyLinkedList()
        {
        }

        public int Length
        {
            get
            {
                int count = 0;
                var currentNode = Head;
                while (currentNode != null)
                {
                    count++;
                    currentNode = currentNode.Next;
                }

                return count;
            }
        }
    }
}
