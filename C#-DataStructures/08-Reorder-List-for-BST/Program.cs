//Reorder List for Binary Search Tree


List<int> sortedList = new List<int>()
{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

List<int> reorderedList = new List<int>();

ReorderListWithMidElements(sortedList, 0, sortedList.Count - 1, reorderedList);

Console.WriteLine(String.Join(" ,", reorderedList));

static void ReorderListWithMidElements(List<int> sortedList, int start, int end, List<int> reorderedList)
{
    if (start > end)
    {
        return;
    }

    var middle = (start + end) / 2;

    reorderedList.Add(sortedList[middle]);
    
    ReorderListWithMidElements(sortedList, start, middle - 1, reorderedList);
    ReorderListWithMidElements(sortedList, middle + 1, end, reorderedList);
}




