class Program
{
    static void Main()
    {
        Save();
        Load();
    }

    private static void Save()
    {
        FileStream s = new(@"d:\data.u", FileMode.Create);

        #region test nodes 1 2 3
        ListNode node1 = new() { Data = "data 1 - test line" };
        ListNode node2 = new() { Data = "data 2", Prev = node1 };
        ListNode node3 = new() { Data = "data 3", Prev = node2 };
        node1.Next = node2;
        node2.Next = node3;
        node1.Rand = node2;
        node2.Rand = node3;
        node3.Rand = node1; 
        #endregion

        ListRandN2 rand = new() { Head = node1, Tail = node3, Count = 3 };
        ListRand randUnsafe = new() { Head = node1, Tail = node3, Count = 3 };

        randUnsafe.Serialize(s);

        s.Close();
    }

    private static void Load()
    {
        FileStream s = new(@"d:\data.u", FileMode.Open);

        ListRandN2 rand = new();
        ListRand randUnsafe = new();

        randUnsafe.Deserialize(s);

        Console.WriteLine(randUnsafe.Tail.Rand.Data);

        s.Close();
    }
}