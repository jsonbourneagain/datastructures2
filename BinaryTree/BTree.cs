using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPart2.BinaryTree
{
    public class BTree
    {
        private class Node
        {
            public int value;
            public Node leftChild;
            public Node rightChild;
            public Node(int value) => this.value = value;
        }
        private Node root;
        private int count = default;

        public void Insert(int value)
        {
            var node = new Node(value);

            if (count == 0)
            {
                root = node;
            }
            else
            {
                // Find out the right place to insert incoming node
                var current = root;
                while (current != null)
                {
                    if (value > current.value)
                    {
                        if (current.rightChild != null)
                            current = current.rightChild;
                        else
                        {
                            current.rightChild = node;
                            break;
                        }
                    }
                    else
                    {
                        if (current.leftChild != null)
                            current = current.leftChild;
                        else
                        {
                            current.leftChild = node;
                            break;
                        }
                    }
                }
            }

            count++;
        }
        public bool Find(int value)
        {
            var current = root;

            while (current != null)
            {
                if (value == current.value)
                    return true;
                else if (value > current.value && current.rightChild != null)
                    current = current.rightChild;
                else if (value < current.value && current.leftChild != null)
                    current = current.leftChild;
                else
                    break;
            }
            return false;
        }
    }
}
