using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.DataStructure
{
    class BinaryTree
    {
        public BinaryTree ParentNode { get; }
        public BinaryTree LeftNode { get; private set; }
        public BinaryTree RightNode { get; private set; }
        public int Value { get; private set; }
        public BinaryTree(int initialValue)
        {
            Value = initialValue;
            ParentNode = null;
        }
        public BinaryTree(BinaryTree parentNode, int initialValue)
        {
            Value = initialValue;
            ParentNode = parentNode;
        }
        public BinaryTree Insert(int value)
        {
            var node = new BinaryTree(this, value);

            if (value <= this.Value)
            {
                if (this.LeftNode == null)
                {
                    this.LeftNode = node;
                }
                else
                {
                    this.LeftNode.Insert(value);
                }
            }
            else if (value > this.Value)
            {
                if (this.RightNode == null)
                {
                    this.RightNode = node;
                }
                else
                {
                    this.RightNode.Insert(value);
                }
            }
            return node;
        }
        public void Traversal()
        {
            this.LeftNode?.Traversal();
            this.RightNode?.Traversal();
        }
        public string Visualize()
        {
            StringBuilder output = new StringBuilder();
            ConstructTreeVisualize(output, 0);
            return output.ToString();
        }

        private void ConstructTreeVisualize(StringBuilder output, int depth)
        {
            if (this.RightNode != null)
            {
                RightNode.ConstructTreeVisualize(output, depth + 1);
            }
            output.Append('\t', depth);
            output.AppendLine(Value.ToString());
            if (LeftNode != null)
            {
                LeftNode.ConstructTreeVisualize(output, depth + 1);
            }
        }
    }
}
