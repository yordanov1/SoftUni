using ImplementList;

//Test List

MyList<int> list = new MyList<int>();

list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);

for (int i = 0; i < list.Count; i++)
{
    Console.Write(list[i]);
    Console.Write(" ");
}

Console.WriteLine();

list.Insert(2, 9);

for (int i = 0; i <= list.Count; i++)
{
    Console.Write(list[i]);
    Console.Write(" ");
}



