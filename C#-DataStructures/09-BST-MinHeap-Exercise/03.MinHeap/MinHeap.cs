namespace _03.MinHeap
{
    using System;
    using System.Collections.Generic;

    public class MinHeap<T> : IAbstractHeap<T>
        where T : IComparable<T>
    {
        private List<T> elements;

        public MinHeap()
        {
            this.elements = new List<T>();
        }

        public int Size => this.elements.Count;

        public T Dequeue()
        {
            if (this.Size == 0)
            {
                throw new InvalidOperationException();
            }


            T element = this.elements[0];
            this.Swap(0, this.Size - 1);
            this.elements.RemoveAt(this.elements.Count - 1);
            HeapifyDown(0);

            return element;
        }

        private void HeapifyDown(int parentIndex)
        {            
            var smallerChildIndex = this.FindSmallerChild(parentIndex * 2 + 1, parentIndex * 2 + 2);

            while (smallerChildIndex != -1 && IsSmaller(smallerChildIndex, parentIndex))
            {
                Swap(smallerChildIndex, parentIndex);
                parentIndex = smallerChildIndex;
                smallerChildIndex = this.FindSmallerChild(parentIndex * 2 + 1, parentIndex * 2 + 2);
            }
        }

        private int FindSmallerChild(int leftChildIndex, int rightChildIndex)
        {
            if (leftChildIndex >= this.Size)
            {
                return -1;
            }

            if (rightChildIndex >= this.Size)
            {
                return leftChildIndex;
            }
            return 
                this.IsSmaller(leftChildIndex, rightChildIndex) 
                ? leftChildIndex 
                : rightChildIndex;
        }

        public void Add(T element)
        {
            this.elements.Add(element);
            this.HeapifyUp(this.Size - 1);
        }

        private void HeapifyUp(int index)
        {
            var parentIndex = (index - 1) / 2;
            while (this.IsSmaller(index, parentIndex))
            {
                this.Swap(index, parentIndex);
                index = parentIndex;
                parentIndex = (index - 1) / 2;
            }
        }

        private void Swap(int index, int parentIndex)
        {
            var temp = this.elements[index];
            this.elements[index] = this.elements[parentIndex];
            this.elements[parentIndex] = temp;
        }

        public bool IsSmaller(int index, int parentIndex)
        {
            return this.elements[index].CompareTo(this.elements[parentIndex]) < 0;
        }

        public T Peek()
        {
            if (this.Size == 0)
            {
                throw new InvalidOperationException();
            }
            return this.elements[0];
        }
    }
}
