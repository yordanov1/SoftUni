namespace ImplementList
{
    using System;
    using System.Collections;

    public class MyList<T> : IEnumerable<T>
    {

        private T[] array;
        private int index = 0;

        public MyList(int initialCapacity = 4)
        {
            array = new T[initialCapacity];
        }


        public int Count { set { } get { return index; } }
        public int InternalArrayCount { get { return array.Length; } }

        
        public T this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                array[i] = value;
            }
        }
        

        public void Add(T element)
        {
            if (index == array.Length)
            {
                array = DoubleArraySize(array);
            }

            array[index++] = element;
        }

        private T[] DoubleArraySize(T[] array)
        {
            T[] newArray = new T[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }

        public void Insert(int index, T item)
        {
            this.ValidateIndexer(index);
            this.GrowIfNecessery();

            for (var i = this.Count; i > index; i--)
            {               
                this.array[i] = this.array[i - 1];              
            }
           
            this.array[index] = item;
            this.Count++;
        }

        private void GrowIfNecessery()
        {
            if (this.Count == this.array.Length)
            {
                this.array = this.Grow();
            }
        }

        private T[] Grow()
        {
            var newArray = new T[this.Count * 2];
            Array.Copy(this.array, newArray, this.array.Length);
            return newArray;
        }

        private void ValidateIndexer(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
