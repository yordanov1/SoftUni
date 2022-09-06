namespace _01.ReverseArray
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine().Split();

            ReverseArray(elements, 0);

            Console.WriteLine(String.Join(" ", elements));
        }

        private static void ReverseArray(string[] elements, int idx)
        {
            if (idx == elements.Length / 2)
            {
                return;
            }

            var temp = elements[idx];
            elements[idx] = elements[elements.Length - idx - 1];
            elements[elements.Length - idx - 1] = temp;

            ReverseArray(elements, idx + 1);
        }
    }
}
