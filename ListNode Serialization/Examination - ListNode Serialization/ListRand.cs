using System.Text;

class ListRand
{
    public ListNode Head;
    public ListNode Tail;
    public int Count;

    public void Serialize(Stream s)
    {
        List<ListNode> list = new();
        for (ListNode currentNode = Head; currentNode != null; currentNode = currentNode.Next)
            list.Add(currentNode);

        using (BinaryWriter writer = new BinaryWriter(s, new ASCIIEncoding()))
        {
            writer.Write(Count);

            for (ListNode currentNode = Head; currentNode != null; currentNode = currentNode.Next)
                writer.Write(currentNode.Data);
            
            for (ListNode currentNode = Head; currentNode != null; currentNode = currentNode.Next)
                writer.Write(list.IndexOf(currentNode.Rand));
        }
    }

    unsafe public void Deserialize(Stream s)
    {
        using (BinaryReader r = new(s))
        {
            Count = r.ReadInt32();

            Head = new();
            ListNode current = Head;
            List<ulong> memoryIds = new();
            for (int i = 0; i < Count; i++)
            {
                current.Data = r.ReadString();

                ListNode next = new();
                next.Prev = current;
                next.Prev.Next = next;
                current = next;

                fixed (ListNode* pointer = &current.Prev)
                    memoryIds.Add((ulong)pointer);
            }
            Tail = current.Prev;
            Tail.Next = null;

            current = Head;
            for (int i = 0; i < Count; i++)
            {
                int index = r.ReadInt32();
                
                ListNode* pointer = (ListNode*)memoryIds[index];
                current.Rand = *pointer;
                current = current.Next;
            }
        }
    }
}