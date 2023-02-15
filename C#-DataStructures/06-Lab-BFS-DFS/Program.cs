using Trees_BFS_DFS;

/*
Node<int> node1 = new Node<int>(1);
Node<int> node2 = new Node<int>(1);
Node<int> node3 = new Node<int>(1);
Node<int> node4 = new Node<int>(1);

node1.Children.Add(node2);
node1.Children.Add(node3);

node2.Children.Add(node4);
*/

Node<int> root = new Node<int>(7,
    new Node<int>(19,
         new Node<int>(1),
         new Node<int>(12),
         new Node<int>(31)),
    new Node<int>(21),
    new Node<int>(14,
         new Node<int>(23),
         new Node<int>(6))
    );

Tree<int> tree = new Tree<int>();
tree.Root = root;


Tree2<int> tree2 = new Tree2<int>();
tree2.Root = root;
/*
List<Node<int>> treeAsList = tree.BFS(root);

Console.WriteLine(String.Join(", ", treeAsList));


List<Node<int>> treeAsList2 = tree.DFSStack(root);

Console.WriteLine(String.Join(", ", treeAsList2));
*/

tree.DFS(root, 0);
tree2.DFS2(root);


