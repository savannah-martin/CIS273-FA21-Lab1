using System;

namespace KthToLast
{
    public class DoublyLinkedListNode<T>
    {
        public T Data { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Prev { get; set; }

        public DoublyLinkedListNode(T data = default(T), DoublyLinkedListNode<T> prev = null, DoublyLinkedListNode<T> next = null)
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

    public class DoublyLinkedList<T> : IList<T>
    {
        public DoublyLinkedListNode<T> Head { get; set; }
        public DoublyLinkedListNode<T> Tail { get; set; }

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
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

        public bool IsEmpty => Head == null;

        public T First => Head.Data;

        public T Last => Tail.Data;

        public void Append(T item)
        {
            var newNode = new DoublyLinkedListNode<T>(item);
            if (IsEmpty)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Prev = Tail;
                Tail.Next = newNode;
                Tail = newNode;
            }
        }

        public void Prepend(T item)
        {
            var newNode = new DoublyLinkedListNode<T>(item);

            newNode.Next = Head;
            Head = newNode;
        }

        public void InsertAfter(T newValue, T existingValue)
        {
            int index = FirstIndexOf(existingValue);

            if (index == -1)
            {
                Append(newValue);
            }
            else
            {
                InsertAt(newValue, index + 1);
            }

        }
        public void InsertAt(T newValue, int index)
        {
            if (index < 0 || index > Length)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == Length)
            {
                var newNode = new DoublyLinkedListNode<T>(newValue);
                var currentNode = Head;

                if (index == 0)
                {
                    Prepend(newValue);
                    return;
                }

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newNode;
                Tail = newNode;
                return;
            }

            if (index == 0)
            {
                Prepend(newValue);
                return;
            }

            if (index > 0 && index < Length)
            {
                var newNode = new DoublyLinkedListNode<T>(newValue);
                int count = 0;
                var currentNode = Head;

                while (currentNode != null)
                {
                    if (count == index - 1)
                    {

                        newNode.Next = currentNode.Next;
                        currentNode.Next = newNode;
                    }
                    count++;
                    currentNode = currentNode.Next;
                }
                return;

            }

        }

        public int FirstIndexOf(T existingValue)
        {
            int index = 0;

            var currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Data.Equals(existingValue))
                {
                    return index;
                }
                index++;
                currentNode = currentNode.Next;
            };
            return -1;
        }

        public void Remove(T value)
        {
            if (IsEmpty)
            {
                return;
            }
            if (Head.Data.Equals(value))
            {
                if (Head == Tail)
                {
                    Tail = null;
                    Head = null;
                }
                else
                {
                    Head = Head.Next;
                }
                return;
            }
            var currentNode = Head;

            while (currentNode != null)
            {
                if (currentNode.Next != null && currentNode.Next.Data.Equals(value))
                {
                    var nodeToDelete = currentNode.Next;
                    if (nodeToDelete == Tail)
                    {
                        currentNode.Next = null;
                        Tail = currentNode;
                    }
                    else
                    {
                        currentNode.Next = currentNode.Next.Next;
                        nodeToDelete.Next = null;
                    }
                }

                currentNode = currentNode.Next;
            }

        }

        public void RemoveAt(int index)
        {
            if (index >= Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            int count = 0;
            var currentNode = Head;
            while (currentNode != null)
            {
                if (count == index)
                {
                    Remove(currentNode.Data);
                }
                count++;
                currentNode = currentNode.Next;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
        }

        public IList<T> Reverse()
        {
            DoublyLinkedList<T> newList = new DoublyLinkedList<T>();

            var currentNode = Tail;
            while (currentNode != null)
            {
                newList.Append(currentNode.Data);
                currentNode = currentNode.Prev;
            }
            return newList;
        }
        public override string ToString()
        {
            string result = "[";
            var currentNode = Head;
            while (currentNode != null)
            {
                result += currentNode.Data;
                if (currentNode.Next != null)
                {
                    result += ", ";
                }
                currentNode = currentNode.Next;
            }

            result += "]";

            return result;
        }

        public T KthToLast(int K)
        {
            int indexToFind = K;

            int index = 0;

            var currentNode = Tail;
            while (currentNode != null)
            {
                if (index == indexToFind)
                {
                    return currentNode.Data;
                }
                index++;
                currentNode = currentNode.Prev;

            }
            return default(T);
        }
    }
}
