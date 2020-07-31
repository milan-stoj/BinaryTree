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
                Root = nodeToAdd;
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
                    CurrentNode = NextNode;
                }
                else if (nodeToAdd.Data < CurrentNode.Data)
                {
                    NextNode = CurrentNode.LeftChild;
                    if (NextNode == null)
                    {
                        CurrentNode.LeftChild = nodeToAdd;
                        return;
                    }
                    CurrentNode = NextNode;
                }
                else if (nodeToAdd.Data == CurrentNode.Data)
                {
                    Console.WriteLine("Node already exists!");
                    return;
                }
            }
        }

        public bool SearchNode(int nodeDataToFind)
        {
            Node CurrentNode = Root;
            Node NextNode;
            while (true)
            {
                if (nodeDataToFind > CurrentNode.Data)
                {
                    NextNode = CurrentNode.RightChild;
                    if (NextNode == null)
                    {
                        Console.WriteLine("Node not found in the tree!");
                        return false;
                    }
                    CurrentNode = NextNode;
                }
                else if (nodeDataToFind < CurrentNode.Data)
                {
                    NextNode = CurrentNode.LeftChild;
                    if (NextNode == null)
                    {
                        Console.WriteLine("Node not found in the tree!");
                        return false;
                    }
                    CurrentNode = NextNode;
                }
                else if (nodeDataToFind == CurrentNode.Data)
                {
                    Console.WriteLine("Node exists in the tree!");
                    return true;
                }
            }
        }
    }
}
