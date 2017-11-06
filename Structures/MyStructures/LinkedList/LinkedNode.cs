using MyStructures.List;

namespace MyStructures.LinkedList
{
    public class LinkedNode : Node
    {
        public LinkedNode Previus { get; set; }

        public LinkedNode(LinkedNode node) : base(node)
        {
            Previus = new LinkedNode(node);
        }
    }
}
