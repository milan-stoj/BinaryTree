using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree newTree = new BinarySearchTree();

            newTree.AddNode(new Node(5));
            newTree.AddNode(new Node(4));
            newTree.AddNode(new Node(6));
            newTree.AddNode(new Node(8));
            newTree.AddNode(new Node(3));
            newTree.AddNode(new Node(2));
            newTree.AddNode(new Node(22));

            newTree.SearchNode(22);

        }
    }
}
