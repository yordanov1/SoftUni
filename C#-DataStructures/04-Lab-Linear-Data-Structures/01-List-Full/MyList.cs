namespace ImplementList2
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyList<T> : IAbstractList<T>
    {
        private const int DEFAULT_CAPACITY = 4;
        private T[] _items;

        public MyList() : this(DEFAULT_CAPACITY)
        {
        }

        public MyList(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity));
            }

            this._items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                return this._items[index];
            }
            set
            {
                this.ValidateIndex(index);
                this._items[index] = value;
            }
        }

        public int Count { get; private set; }
       

        public void Add(T item)
        {
            if (Count == _items.Length)
            {
                _items = DoubleArraySize(_items);
            }

            _items[Count++] = item;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this._items[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(T item)
        {
            int index = -1;

            if (this.Contains(item))
            {
                for (int i = 0; i < this.Count; i++)
                {
                    if (this._items[i].Equals(item))
                    {
                        index = i;
                    }
                }
            }

            return index;
        }

        public void Insert(int index, T item)
        {
            this.ValidateIndex(index);
            this.GrowIfNecessary();

            for (int i = this.Count; i > index; i--)
            {
                this._items[i] = this._items[i - 1];
            }

            this[index] = item;
            this.Count++;
        }

        public bool Remove(T item)
        {
            if (this.Contains(item))
            {
                var index = this.IndexOf(item);

                for (int i = index; i < this.Count; i++)
                {
                    this._items[i] = this._items[i + 1];
                }

                this._items[this.Count - 1] = default;
                this.Count--;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveAt(int index)
        {
            this.ValidateIndex(index);

            for (int i = index; i < this.Count - 1; i++)
            {
                this._items[i] = this._items[i + 1];
            }

            this._items[this.Count - 1] = default;
            this.Count--;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this._items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();        

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
        }
        
        private void GrowIfNecessary()
        {
            if (this.Count == this._items.Length)
            {
                this._items = this.Grow();
            }
        }

        private T[] Grow()
        {
            var newArray = new T[this.Count * 2];
            Array.Copy(this._items, newArray, this._items.Length);
            return newArray;
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

    }
}
