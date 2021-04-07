using System;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings stack = new StackOfStrings();

            Console.WriteLine(stack.IsEmpty());

            stack.AddRange(new string[] { "a", "b", "c" });

            Console.WriteLine(stack.IsEmpty());

            Console.WriteLine(stack.Count);
        }
    }
}
