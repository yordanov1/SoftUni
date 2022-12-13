namespace _01.BSTOperations
{
    using System;
    using System.Collections.Generic;

    public class BinarySearchTree<T> : IAbstractBinarySearchTree<T>
        where T : IComparable<T>
    {
        public BinarySearchTree()
        {
        }

        public BinarySearchTree(Node<T> root)
        {
            this.CopyNode(root);
        }

        private void CopyNode(Node<T> node)
        {
            if (node != null)
            {
                this.Insert(node.Value);
                this.CopyNode(node.LeftChild);
                this.CopyNode(node.RightChild);
            }
        }

        public Node<T> Root { get; private set; }

        public int Count { get; private set; }


        public bool Contains(T element)
        {            
            var node = this.Root;

            while (node != null)
            {
                if (IsGreater(node.Value, element))
                {
                    node = node.LeftChild;
                }
                else if (IsSmaller(node.Value, element))
                {
                    node = node.RightChild;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public void Insert(T element)
        {
            var newNode = new Node<T>(element);

            if (this.Count == 0)
            {
                this.Root = newNode;
                this.Count++;
                return;
            }

            Node<T> parentNode = null;

            var node = this.Root;

            while (node != null)
            {                
                parentNode = node;

                if (IsGreater(node.Value, element))
                {                    
                    node = node.LeftChild;                                   
                }
                else if (IsSmaller(node.Value, element))
                {
                    node = node.RightChild;                                    
                }
            }

            if (IsGreater(parentNode.Value, element))
            {
                parentNode.LeftChild = newNode;
            }
            else
            {
                parentNode.RightChild = newNode;
            }

            this.Count++;
        }

        private bool IsGreater(T value, T other)
        {
            return value.CompareTo(other) > 0;
        }

        private bool IsSmaller(T value, T other)
        {
            return value.CompareTo(other) < 0;
        }

        public IAbstractBinarySearchTree<T> Search(T element)
        {
            var node = this.Root;

            while (node != null)
            {

                if (IsGreater(node.Value, element))
                {
                    node = node.LeftChild;
                }
                else if (IsSmaller(node.Value, element))
                {
                    node = node.RightChild;
                }
                else
                {
                    break;
                }
            }
            
            return node == null ? null : new BinarySearchTree<T>(node);
        }

        public void EachInOrder(Action<T> action)
        {
            this.EachInOrder(action, this.Root);
        }

        private void EachInOrder(Action<T> action, Node<T> node)
        {
            if (node == null)
            {
                return;
            }

            this.EachInOrder(action, node.LeftChild);
            action(node.Value);
            this.EachInOrder(action, node.RightChild);
        }

        //Return all nods betwean lower and upper 
        public List<T> Range(T lower, T upper)
        {
            var list = new List<T>();

            this.Range(lower, upper, this.Root, list);

            return list;
        }

        private void Range(T startRange, T endRange, Node<T> node, List<T> result)
        {
            if (node == null)
            {
                return;
            }

            var inStartRange = startRange.CompareTo(node.Value);
            var inEndRange = endRange.CompareTo(node.Value);

            if (inStartRange < 0)
            {
                this.Range(startRange, endRange, node.LeftChild, result);
            }

            if (inStartRange <= 0 && inEndRange >= 0)
            {
                result.Add(node.Value);
            }

            if (inEndRange > 0)
            {
                this.Range(startRange, endRange, node.RightChild, result);
            }
        }

        public void DeleteMin()
        {
            throw new NotImplementedException();
        }

        public void DeleteMax()
        {
            throw new NotImplementedException();
        }

        public int GetRank(T element)
        {
            throw new NotImplementedException();
        }
        
    }
}
