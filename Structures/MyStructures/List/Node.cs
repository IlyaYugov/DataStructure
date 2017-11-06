namespace MyStructures.List
{
    public class Node : INode
    {
        public Node(string name, object information, Node next)
        {
            Name = name;
            Information = information;
            Next = next != null 
                ? new Node(next.Name, next.Information, next.Next)
                : null;
        }

        public Node(Node current) : this(current.Name, current.Information, current.Next)
        {
        }

        public string Name { get; set; }

        public object Information { get; set; }

        public Node Next { get; set; }
    }
}
