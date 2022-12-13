using StackImplementation;


//Test Stack

MyStack<int> stack = new MyStack<int>();

for (int i = 0; i <= 10; i++)
{
    stack.Push(i);
}

Console.WriteLine(stack.Peek());

stack.Push(99);
Console.WriteLine(stack.Peek());

stack.Pop();
Console.WriteLine(stack.Peek());


while (stack.Count > 0)
{
    Console.WriteLine(stack.Pop());
}

