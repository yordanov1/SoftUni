namespace QueueImplementation
{
    using SinglyLinkedList;

    public class MyQueue<T>
    {
        private MyLinkedList<T> linkedList;

        public MyQueue()
        {
            linkedList = new MyLinkedList<T>();
        }


        public int Count { get { return linkedList.Count; } }
       
        public void Enqueue(T element)
        {
            linkedList.AddLast(element);
        }

        public T Peek()
        {
            return linkedList.Head.Value;
        }

        public T Dequeue()
        {
            return linkedList.RemoveHead().Value;
        }
    }
}
