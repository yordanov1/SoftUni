using TestBSTVE;



BinaryTree tree = new BinaryTree();

List<int> arr = new List<int>();


for (int i = 0; i < 25; i += 2)
{
    arr.Add(i);
}


int n = arr.Count;

Node root = null;


root = tree.sortedArrayToBST(arr, 0, n - 1);


Console.WriteLine(DFSInOrder(root, 0));


static string DFSInOrder(Node node, int indent)
{
    string result = "";
    if (node.left != null)
    {
        result += DFSInOrder(node.left, indent + 3);
    }

    result += $"{new string(' ', indent) }{node.value}\n";

    if (node.right != null)
    {
        result += DFSInOrder(node.right, indent + 3);
    }

    return result;
}