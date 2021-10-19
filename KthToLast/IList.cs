using System;
namespace KthToLast
{
    public interface IList<T>
    {
        // Add i to start of the list
        void Prepend(T item);

        // Add i to end of list
        void Append(T item);

        // Returns length of list 
        int Length { get; }

        // Returns true if list contains no items.
        bool IsEmpty { get; }

        // return first item in list
        T First { get; }

        // return last item in list
        T Last { get; }

        // Return the item at given index
        T this[int index] { get; }

        // Returns true if i is in list
        bool Contains(T item);

        // Remove the first item with value of i in the list
        void Remove(T item);

        // Remove item at given index
        void RemoveAt(int index);

        // Insert item i at given index
        void InsertAt(int index, T item);

        // Returns a new arraylist that's the reverse
        IList<T> Reverse();

        // Make the list empty
        void Clear();

        T KthToLast(int k);
    }

}