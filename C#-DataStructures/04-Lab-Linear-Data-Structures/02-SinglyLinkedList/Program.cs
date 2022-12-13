using SinglyLinkedList;


MyLinkedList<int> linkedList = new MyLinkedList<int>();


for (int i = 0; i < 10; i++)
{
    linkedList.AddLast(i);
}




var currentNode = linkedList.Head;


while (currentNode != null)
{
    Console.WriteLine(currentNode.Value);
    currentNode = currentNode.Next; 
}