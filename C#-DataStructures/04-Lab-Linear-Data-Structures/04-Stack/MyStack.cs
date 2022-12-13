namespace StackImplementation
{
    using SinglyLinkedList;

    public class MyStack<T>
    {

        private MyLinkedList<T> linkedList;

        public MyStack()
        {
            linkedList = new MyLinkedList<T>();
        }

        public int Count { get { return linkedList.Count; } }


        public void Push(T element)
        {
            linkedList.Add(element);
        }

        public T Peek()
        {
            return linkedList.Head.Value;
        }

        public T Pop()
        {
            return linkedList.RemoveHead().Value;
        }
    }
}
