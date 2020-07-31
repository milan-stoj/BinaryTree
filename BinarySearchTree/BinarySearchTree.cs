using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node Root;

        public void AddNode(Node nodeToAdd)
        {
            if (Root == null)
            {
                AddRootNode(nodeToAdd);
                return;
            }

            Node CurrentNode = Root;
            Node NextNode;
            while (true)
            {
                if (nodeToAdd.Data > CurrentNode.Data)
                {
                    NextNode = CurrentNode.RightChild;
                    if (NextNode == null)
                    {
                        CurrentNode.RightChild = nodeToAdd;
                        return;
                    }
                }
                else if (nodeToAdd.Data < CurrentNode.Data)
                {
                    NextNode = CurrentNode.LeftChild;
                    if (NextNode == null)
                    {
                        CurrentNode.LeftChild = nodeToAdd;
                        return;
                    }
                }
                else if (nodeToAdd.Data == CurrentNode.Data)
                {
                    Console.WriteLine("Node already exists!");
                    return;
                }
            }
        }

        private void AddRootNode(Node nodeToAdd)
        {
            Root = nodeToAdd;
        }
    }
}
