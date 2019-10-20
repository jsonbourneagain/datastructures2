using System;
using DataStructuresPart2.BinaryTree;

namespace DataStructuresPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            BTree bTree = new BTree();
            bTree.Insert(5);
            bTree.Insert(6);
            bTree.Insert(4);
            bTree.Insert(3);
            bTree.Insert(7);
            bTree.Insert(9);
            //bTree.InOrderTraversal();
            //bTree.PreOrderTraversal();
            //bTree.PostOrderTraversal();
            Console.WriteLine(bTree.Height());
        }
    }
}
