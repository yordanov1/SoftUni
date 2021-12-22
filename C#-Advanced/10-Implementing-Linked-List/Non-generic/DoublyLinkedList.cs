using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDoublyLinkedList
{
    public class DoublyLinkedList
    {
        private LinkedListItem first = null;
        private LinkedListItem last = null;

        // Read-only property (get only)
        public int Count
        {
            get
            {
                int count = 0;

                LinkedListItem current = first;
                while (current != null)
                {
                    count++;
                    current = current.Next;
                }

                return count;
            }
        }

        // Get count with recursion
        public int GetCount(LinkedListItem current)
        {
            if (current == null)
            {
                return 0;
            }

            return 1 + GetCount(current.Next);
        }

        // adds an element at the beginning of the collection
        public void AddFirst(int element)
        {
            LinkedListItem newItem = new LinkedListItem(element);
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

        // adds an element at the end of the collection
        public void AddLast(int element)
        {
            LinkedListItem newItem = new LinkedListItem(element);
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
        public int RemoveFirst()
        {
            if (first == null) // 0 items
            {
                throw new InvalidOperationException("Linked list empty!");
            }

            int currentFirstValue = first.Value;
            if (first == last) // 1 item
            {
                first = null;
                last = null;
            }
            else // more than 1 item
            {
                LinkedListItem newFirst = first.Next;
                newFirst.Previous = null;
                first = newFirst;
            }

            return currentFirstValue;
        }

        // removes the element at the end of the collection
        public int RemoveLast()
        {
            if (last == null)
            {
                throw new InvalidOperationException("Linked list empty!");
            }

            int currentLastValue = last.Value;
            if (first == last)
            {
                first = null;
                last = null;
            }
            else
            {
                LinkedListItem newLast = last.Previous;
                newLast.Next = null;
                last = newLast;
            }

            return currentLastValue;
        }

        // goes through the collection and executes a given action
        // void method(int element)
        public void ForEach(Action<int> action)
        {
            /*
            var elements = ToArray();
            foreach (var element in elements)
            {
                action(element);
            }
            */

            LinkedListItem current = first;
            while(current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }

        // returns the collection as an array
        public int[] ToArray()
        {
            int[] array = new int[Count];

            LinkedListItem current = first;
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
