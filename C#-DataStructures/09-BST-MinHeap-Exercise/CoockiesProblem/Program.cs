using _03.MinHeap;


int[] cookies = new int[] { 1, 2, 3, 9, 10, 12 };
int k = cookies.Length;

Console.WriteLine(Solve2(k, cookies));

static int Solve2(int k, int[] cookies)
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
