using ImplementList2;


//Test List

MyList<int> list = new MyList<int>();

list.Add(1);
list.Add(2);
list.Add(3);    
list.Add(4);

list.RemoveAt(1);

Console.WriteLine(String.Join(" ", list));

list.Insert(1, 8);

Console.WriteLine(String.Join(" ", list));

