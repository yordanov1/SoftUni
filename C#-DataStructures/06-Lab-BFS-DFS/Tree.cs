namespace Trees_BFS_DFS
{
    using System;
    using System.Collections.Generic;

    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public void DFS(Node<T> node, int level)
        {
            Console.Write(new string(' ', level));
            Console.WriteLine(node);

            foreach (var child in node.Children)
            {
                DFS(child, level + 3);
            }
        }


        public List<Node<T>> BFS(Node<T> root)
        {
            List<Node<T>> list = new List<Node<T>>();
            Queue<Node<T>> queue = new Queue<Node<T>>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();
                list.Add(node);

                foreach (var child in node.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return list;
        }

        public List<Node<T>> DFSStack(Node<T> root)
        {
            List<Node<T>> list = new List<Node<T>>();
            Stack<Node<T>> stack = new Stack<Node<T>>();

            stack.Push(root);

            while (stack.Count > 0)
            {
                Node<T> node = stack.Pop();
                list.Add(node);

                foreach (var child in node.Children)
                {
                    stack.Push(child);
                }
            }

            return list;
        }
    }
}
