/* Let us create following BST
          50
       /     \
      30      70
     /  \    /  \
   20   40  60   80 */

using System.Collections.Generic;

namespace BinaryTree
{
    public class Tree
    {
        public Node Root { get; set; }
        public Tree(Node n)
        {
            Root = n;
        }

        public int GetMin(Node root)
        {
            Node cur = root;
            while (cur.Left != null)
                cur = cur.Left;
            return cur.Value;
        }

        public int GetMax(Node root)
        {
            Node cur = root;
            while (cur.Right != null)
                cur = cur.Right;
            return cur.Value;
        }
        public void AddNode(int val)
        {
            if (Root == null)
            {
                Root = new Node(val);
            }
            else
            {
                AddNode(val, Root);
            }
        }
        private void AddNode(int val, Node current)
        {
            if (val < current.Value)
            {
                if (current.Left == null)
                    current.Left = new Node(val);
                else
                    AddNode(val, current.Left);
            }

            if (val > current.Value)
            {
                if (current.Right == null)
                    current.Right = new Node(val);
                else
                    AddNode(val, current.Right);
            }
        }

        public bool isBST(Node node, int min, int max)
        {
            if (node.Value < min || node.Value > max)
            {
                return false;
            }
            var IsLeft = isBST(node.Left, min, node.Value - 1);
            var IsRight = isBST(node.Right, node.Value + 1, max);
            var results = (IsLeft && IsRight);
            return results;
        }

        //public Node constructBalancedTree(List<int> values, int min, int max)
        //{
        //    if (min == max)
        //        return null;

        //    int median = min + (max - min) / 2;
        //    return new Tree
        //    {
        //        Value = values[median],
        //        Left = constructBalancedTree(values, min, median),
        //        Right = constructBalancedTree(values, median + 1, max)
        //    };
        //}

        public int GetRight(Node n, int index)
        {
            int counter = 0;
            while (n.Right != null)
            {
                counter++;
                if (counter == index)
                    break;

                n = n.Right;
            }
            return n.Value;
        }

        public int GetLeft(Node n, int index)
        {
            int counter = 0;
            while (n.Left != null)
            {
                counter++;
                if (counter == index)
                {
                    break;
                }
                n = n.Left;
            }
            return n.Value;
        }


    }
}
