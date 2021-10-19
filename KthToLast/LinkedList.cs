using System;
namespace KthToLast
{
    public class LinkedListNode<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T data=default(T), LinkedListNode<T> next=null)
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

        public T this[int index]
        {
            get
            {
                if( index < 0 || index > Length - 1 )
                {
                    throw new IndexOutOfRangeException();
                }

                int currentIndex = 0;
                for (var currentNode = Head; currentNode != null; currentNode = currentNode.Next)
                {
                    if(currentIndex == index)
                    {
                        return currentNode.Data;
                    }

                    currentIndex++;
                }

                throw new IndexOutOfRangeException();
            }
        }


        // TODO
        public int Length => throw new NotImplementedException();

        public bool IsEmpty => Head == null;

        public T First => Head==null? default : Head.Data;

        public T Last => Tail == null ? default : Tail.Data;

        public void Append(T item)
        {
            // create a new node
            var newNode = new LinkedListNode<T>(item);

            if (IsEmpty)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                // add to the end
                Tail.Next = newNode;

                // update tail
                Tail = newNode;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
        }

        public bool Contains(T item)
        {
            for( var currentNode = Head; currentNode != null; currentNode = currentNode.Next)
            {
                if (currentNode.Data.Equals(item) )
                {
                    return true;
                }
            }

            return false;
        }

        // TODO
        public void InsertAt(int index, T item)
        {
            throw new NotImplementedException();
        }

        // TODO
        public void Prepend(T item)
        {
            throw new NotImplementedException();
        }

        // TODO
        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        // TODO
        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public IList<T> Reverse()
        {
            var reversedList = new LinkedList<T>();

            for( var currentNode = Head; currentNode != null; currentNode= currentNode.Next)
            {
                reversedList.Prepend(currentNode.Data);
            }

            return reversedList;
        }

        public override string ToString()
        {

            string s = "[";

            LinkedListNode<T> currentNode = Head;

            while(currentNode != null )
            {
                s += currentNode.Data;
                if(currentNode != Tail)
                {
                    s += ", ";
                }
                
                currentNode = currentNode.Next;
            }

            s += "]";

            return s;

        }
    }
}
