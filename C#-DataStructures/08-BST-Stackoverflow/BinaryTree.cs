namespace TestBSTVE
{
    using System;
    using System.Collections.Generic;

    public class BinaryTree
    {
        public static Node root;

        public virtual Node sortedArrayToBST(List<int> arr, int start, int end)
        {
            if (start > end)
            {
                return null;
            }


            int mid = (start + end) / 2;

            Node node = new Node(arr[mid]);


            node.left = sortedArrayToBST(arr, start, mid - 1);
            node.right = sortedArrayToBST(arr, mid + 1, end);

            return node;
        }
     
        public virtual void preOrder(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.value + " ");
            preOrder(node.left);
            preOrder(node.right);
        }
    }
}
