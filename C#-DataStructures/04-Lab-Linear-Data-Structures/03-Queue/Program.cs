using QueueImplementation;

//Test Queue 

MyQueue<int> queue = new MyQueue<int>();

for (int i = 0; i <= 10; i++)
{
    queue.Enqueue(i);
}

Console.WriteLine(queue.Peek());

queue.Dequeue();
queue.Dequeue();

Console.WriteLine(queue.Peek());

queue.Enqueue(99);

Console.WriteLine(queue.Peek());

while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}


