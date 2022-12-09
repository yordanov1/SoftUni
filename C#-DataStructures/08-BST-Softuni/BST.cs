namespace BinarySearchTrees
{
    using CommonDataStructures;
    using System;

    public class BST<T> where T : IComparable<T>
    {
        public BST(Node<T> root = null)
        {
            Root = root;
        }

        public Node<T> Root { get; set; }
        
        public void Insert(T value, Node<T> node)
        {
            if (node == null)
            {
                node = new Node<T>(value);
                Root = node;
                return;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                if (node.LeftChild == null)
                {
                    node.LeftChild = new Node<T>(value);
                    return;
                }

                Insert(value, node.LeftChild);
            }
            else
            {
                if (node.RightChild == null)
                {
                    node.RightChild = new Node<T>(value);
                    return;
                }

                Insert(value, node.RightChild);
            }
        }
        
        public bool Contains(T value, Node<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.Value.CompareTo(value) == 0)
            {
                return true;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                return Contains(value, node.LeftChild);
            }
            else
            {
                return Contains(value, node.RightChild);
            }

        }

        public Node<T> Search(T value, Node<T> node)
        {
            if (node == null)
            {
                return null;
            }
            if (node.Value.CompareTo(value) == 0)
            {
                return node;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                return Search(value, node.LeftChild);
            }
            else
            {
                return Search(value, node.RightChild);
            }

        }

        private bool IsGreater(T value, T other)
        {
            return value.CompareTo(other) > 0;
        }

        private bool IsSmaller(T value, T other)
        {
            return value.CompareTo(other) < 0;
        }
    }
}
