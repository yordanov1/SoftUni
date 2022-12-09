using MyHeap;

// Heap ---------------------------------------------------------------------->
var integerHeep = new MyHeap<int>();
var elements = new List<int>() { 15, 6, 9, 5, 25, 8, 17, 16};

foreach (var el in elements)
{
  integerHeep.Add(el);
}

Console.WriteLine(integerHeep.DFSInOrder(0, 0));
Console.WriteLine("\n");



// Queue --------------------------------------------------------------------->
var queue = new PriorityQueue<int>();
elements = new List<int>() { 15, 25, 6, 9, 5, 8, 17, 16 };

foreach (var element in elements)
{
    queue.Add(element);
}

while (queue.Size > 0)
{
    //Console.WriteLine(queue.DFSInOrder(0, 0));
    Console.WriteLine($"Max element: {queue.Deqeueue()}");
}
