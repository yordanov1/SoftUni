using _03.MinHeap;
using System;
using System.Linq;
using Wintellect.PowerCollections;

namespace _04.CookiesProblem
{
    public class CookiesProblem
    {
        public int Solve(int k, int[] cookies)
        {
            // Wintellect.PowerCollections;
            var bag = new OrderedBag<int>(cookies);

            var smalestElement = bag.GetFirst();
            var steps = 0;
            while (smalestElement < k && bag.Count > 1)
            {
                var smallestCookie = bag.RemoveFirst();
                var secondSmallestCookie = bag.RemoveFirst();

                steps++;
                bag.Add(smallestCookie + 2 * secondSmallestCookie);
                smalestElement = bag.GetFirst();
            }
            
            return smalestElement >= k ? steps : -1;
        }

        public int Solve2(int k, int[] cookies)
        {
            var bag = new MinHeap<int>();
            cookies.ToList().ForEach(x => bag.Add(x));

            var smalestElement = bag.Peek();
            var steps = 0;
            while (smalestElement < k && bag.Size > 1)
            {
                var smallestCookie = bag.Dequeue();
                var secondSmallestCookie = bag.Dequeue();

                steps++;
                bag.Add(smallestCookie + 2 * secondSmallestCookie);
                smalestElement = bag.Peek();
            }

            return smalestElement >= k ? steps : -1;
        }
    }
}
