

List<String> CreateMassiveString()
{
    List<String> list = new List<String>();
    string s;
    s = Convert.ToString(Console.ReadLine());
    while(s != "")
    {
        list.Add(s);
        s = Console.ReadLine();
    }
    return list;
}

void PrintList(List<String> list)
{
    Console.Write("[");
    for(int i = 0; i < list.Count - 1; ++i)
    {
        Console.Write($"\"{list[i]}\", ");
    }
    Console.WriteLine($"\"{list[list.Count - 1]}\"]");
}

List<String> CreateThreeWordList(List<String> list)
{
    List<String> thrlist = new List<String>();
     for(int i = 0; i < list.Count; ++i)
     {
        if(list[i].Length <= 3)
            thrlist.Add(list[i]);
     }

    return thrlist;
}

List<String> list = CreateMassiveString();
List<String> list2 = CreateThreeWordList(list);
PrintList(list);
PrintList(list2);




