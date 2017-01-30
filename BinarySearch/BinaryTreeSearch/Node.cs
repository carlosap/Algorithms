namespace BinaryTree
{
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(int i)
        {
            this.Value = i;
            this.Left = null;
            this.Right = null;
        }
    }
}

