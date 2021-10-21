using System;
namespace PracticeExercise2
{

    public class LinkedListNode<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T data = default(T), LinkedListNode<T> next = null)
        {
            Data = data;
            Next = next;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }


    public class LinkedList<T> : IList<T>
    {
        public LinkedListNode<T> Head { get; set; }
        public LinkedListNode<T> Tail { get; set; }


        public LinkedList()
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
                while( currentNode != null )
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
            var newNode = new LinkedListNode<T>(item);

            // empty list
            if (IsEmpty)
            {
                Head = newNode;
                Tail = newNode;
            }
            // non empty list
            else
            {
                // Add new node after Tail
                Tail.Next = newNode;

                // Update Tail
                Tail = newNode;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
        }

        public int FirstIndexOf(T existingValue)
        {
            int index = 0;

            var currentNode = Head;
            while (currentNode.Next != null)
            {
                if (currentNode.Data.Equals(existingValue))
                {
                    return index;
                }
                index++;
                currentNode = currentNode.Next;
            }

            //for ( currentNode = Head, index=0; currentNode.Next != null; currentNode = currentNode.Next, index++)
            //{
            //    if (currentNode.Data.Equals(existingValue))
            //    {
            //        return index;
            //    }
            //}

            return -1;

        }

        public void InsertAfter(T newValue, T existingValue)
        {
            throw new NotImplementedException();
        }

        public void InsertAt(T newValue, int index)
        {
            throw new NotImplementedException();
        }

        public void Prepend(T item)
        {
            throw new NotImplementedException();
        }

        public void Remove(T value)
        {
            // If the list is empty, return immediately 
            if (IsEmpty)
            {
                return;
            }
            
            // Remove head
            if (Head.Data.Equals(value))
            {
                // Removing node from 1-element list
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

            // Remove non-head node

            var currentNode = Head;

            while (currentNode != null)
            {
                if( currentNode.Next != null && currentNode.Next.Data.Equals(value))
                {
                    var nodeToDelete = currentNode.Next;
                    if (nodeToDelete == Tail)
                    {
                        currentNode.Next = null;
                        Tail = currentNode;
                    }
                    else
                    {
                        // update previous node's next to skip the deleted node
                        currentNode.Next = currentNode.Next.Next;
                        nodeToDelete.Next = null;
                    }
                }

                currentNode = currentNode.Next;
            }

        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public IList<T> Reverse()
        {
            var result = new LinkedList<T>();

            var currentNode = Head;
            while ( currentNode != null)
            {
                //Prepend every single one of them
                result.Prepend( currentNode.Data);

                currentNode = currentNode.Next;
            }
            
            return result;
        }

        public override string ToString()
        {
            string result = "[";
            var currentNode = Head;
            while( currentNode != null)
            {
                result += currentNode.Data;
                if( currentNode != Tail)
                {
                    result += ", ";
                }
                currentNode = currentNode.Next;
            }

            result += "]";

            return result;
        }
    }
}
