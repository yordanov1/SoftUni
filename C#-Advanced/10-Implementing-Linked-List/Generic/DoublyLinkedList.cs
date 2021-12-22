using System;

namespace ImplementDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private LinkedListItem<T> first = null;
        private LinkedListItem<T> last = null;

        // Read-only property (get only)
        public int Count
        {
            get
            {
                int count = 0;

                LinkedListItem<T> current = first;
                while (current != null)
                {
                    count++;
                    current = current.Next;
                }

                return count;
            }
        }

        // Get count with recursion / GetCount(first)
        public int GetCount(LinkedListItem<T> current)
        {
            if (current == null)
            {
                return 0;
            }

            return 1 + GetCount(current.Next);
        }

        // adds an element at the beginning of the collection
        public void AddFirst(T element)
        {
            LinkedListItem<T> newItem = new LinkedListItem<T>(element);
            if (first == null)
            {
                first = newItem;
                last = newItem;
            }
            else
            {
                newItem.Next = first;
                first.Previous = newItem;
                first = newItem;
            }
        }

        public void DeleteByValue(T value)
        {
            var current = first;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    // TODO: current == first
                    // TODO: current == last
                    current.Next.Previous = current.Previous;
                    current.Previous.Next = current.Next;
                    break;
                }

                current = current.Next;
            }
        }

        // adds an element at the end of the collection
        public void AddLast(T element)
        {
            LinkedListItem<T> newItem = new LinkedListItem<T>(element);
            if (last == null)
            {
                first = newItem;
                last = newItem;
            }
            else
            {
                last.Next = newItem;
                newItem.Previous = last;
                last = newItem;
            }
        }

        // removes the element at the beginning of the collection
        public T RemoveFirst()
        {
            if (first == null) // 0 items
            {
                throw new InvalidOperationException("Linked list empty!");
            }

            T currentFirstValue = first.Value;
            if (first == last) // 1 item
            {
                first = null;
                last = null;
            }
            else // more than 1 item
            {
                LinkedListItem<T> newFirst = first.Next;
                newFirst.Previous = null;
                first = newFirst;
            }

            return currentFirstValue;
        }

        // removes the element at the end of the collection
        public T RemoveLast()
        {
            if (last == null)
            {
                throw new InvalidOperationException("Linked list empty!");
            }

            T currentLastValue = last.Value;
            if (first == last)
            {
                first = null;
                last = null;
            }
            else
            {
                LinkedListItem<T> newLast = last.Previous;
                newLast.Next = null;
                last = newLast;
            }

            return currentLastValue;
        }

        // goes through the collection and executes a given action
        // void method(int element)
        public void ForEach(Action<T> action)
        {
            /*
            var elements = ToArray();
            foreach (var element in elements)
            {
                action(element);
            }
            */

            LinkedListItem<T> current = first;
            while(current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }

        // returns the collection as an array
        public T[] ToArray()
        {
            T[] array = new T[Count];

            LinkedListItem<T> current = first;
            int index = 0;
            while(current != null)
            {
                array[index] = current.Value;
                index++;
                current = current.Next;
            }

            return array;
        }
    }
}
