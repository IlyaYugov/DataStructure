namespace MyStructures.List
{
    public class List
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public Node Current { get; set; }
        public int Lenght { get; set; }

        public void Add(Node node)
        {
            if(Lenght == 0)
            {
                Head = node;
                Tail = node;
                Current = node;
                Lenght = 1;
            }
            return;

            Current.Next = node;
            Lenght++;

        }

        public void Remove(Node node)
        {
            
        }

        public void Next() => Current = new Node(Current.Next);  
    }
}
