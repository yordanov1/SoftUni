

using _01.BSTOperations;

BinarySearchTree<int> tree = new BinarySearchTree<int>();

tree.Insert(12);
tree.Insert(21);
tree.Insert(5);
tree.Insert(1);
tree.Insert(8);
tree.Insert(18);
tree.Insert(23);


//tree.EachInOrder(Console.WriteLine);

var rangeList = tree.Range(5, 21);

foreach (var node in rangeList)
{
    Console.WriteLine(node);
}

