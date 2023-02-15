namespace Trees_BFS_DFS
{
    using System.Collections.Generic;
    using System.Linq;

    public class Node<T>
    {
        public Node(T value, params Node<T>[] children)
        {
            Value = value;
            Children = children.ToList();
        }
        
        public T Value { get; set; }
        public List<Node<T>> Children { get; set; }


        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
