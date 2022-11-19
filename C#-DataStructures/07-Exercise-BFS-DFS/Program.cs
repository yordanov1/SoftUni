

using Trees_DFS_BFS;


string[] input = new string[]
           {
                "7 19",
                "7 21",
                "7 14",
                "19 1", 
                "19 12",
                "19 31",
                "14 23",
                "14 6"
           };


TreeFactory treeFactory = new TreeFactory();



//(1) Create Tree ----------------------------------------------------->
Tree<int> tree = treeFactory.CreateTreeFromStrings(input);



//(2) Tree as string -------------------------------------------------->
Console.WriteLine("Print Tree as String");
Console.WriteLine(tree.GetAsString());



//( )Return Tree as List ---------------------------------------------->
Console.WriteLine("Return Tree as List");
var toPrint = tree.GetTreeAsList();
foreach (var item in toPrint)
{
    Console.WriteLine(item);
}



//(3) Leafs nodes ----------------------------------------------------->
Console.WriteLine("Return leafs and Print");
var leafNodes = tree.GetLeafNodes();
var leafNodesKeys = leafNodes.Select(x => x.Key).ToList();

foreach (var leaf in leafNodesKeys)
{
    Console.WriteLine(leaf);
}



//(4) Middle nodes ---------------------------------------------------->
Console.WriteLine("Get Mid Keys");
var midKeys = tree.GetMiddleKeys();

Console.WriteLine(String.Join(" ", midKeys));



//(5) Deepest Node ---------------------------------------------------->
Console.WriteLine("Deepest Node");
var deepestLeafe = tree.GetDeepestLeftomostNode();
Console.WriteLine(deepestLeafe.Key);



//(6) Longest Path ---------------------------------------------------->
Console.WriteLine("Longest Path");
var longestPath = tree.GetLongestPath();
Console.WriteLine(String.Join(" ,", longestPath));



//(7)(1) All Paths With a Given Sum(from leafs to root) --------------->
Console.WriteLine("(1)Get Paths with Sum (from leafs to root)");

var paths = tree.PathsWithGivenSum(27);

Console.WriteLine("start1");

foreach (var path in paths)
{
    Console.WriteLine(String.Join(" ", path));
}



//(7)(2) All Paths With a Given Sum(from root to leafs) -------------->
Console.WriteLine("(2)Get Paths with Sum (from root to leafs)");
var paths2 = tree.PathsWithGivenSum2(27);

Console.WriteLine("start2");

foreach (var path in paths)
{
    Console.WriteLine(String.Join(" ", path));    
}



//(8) All Subtrees With a Given Sum ---------------------------------->
Console.WriteLine("All subtrees with  a given Sum");

var subtree = tree.SubTreesWithGivenSum(43);
foreach (var node in subtree)
{
    Console.WriteLine(node.Key);
}




