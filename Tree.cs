using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ReizTechAssignment
{
    public class Tree
    {
        //Structure of a node of an n-arry tree
        class Node
        {
            public char key;
            public List<Node> child;
        };
        //Creating a new tree node
        static Node NewNode(int key)
        {
            Node temp = new Node();
            temp.key = (char)key;
            temp.child = new List<Node>();
            return temp;
        }
        //Function that returns the depth of the tree
        static int DepthOfTree(Node ptr)
        {
            if (ptr == null)
                return 0;

            int maxDepth = 0;

            //Checking for all children and finding the maximum depth
            foreach (Node it in ptr.child)
                maxDepth = Math.Max(maxDepth, DepthOfTree(it));

            return maxDepth + 1;
        }

        public static void Run()
        {
            //Hierarchical structure
            //            A
            //           / \
            //          B   C
            //         /  / | \
            //        D  E  F  G
            //          /  / \
            //         H  I   J
            //            |
            //            K
            //
            //Recreating the same structure

            Node root = NewNode('A');
            (root.child).Add(NewNode('B'));
            (root.child).Add(NewNode('C'));
            (root.child[0].child).Add(NewNode('D'));
            (root.child[1].child).Add(NewNode('E'));
            (root.child[1].child).Add(NewNode('F'));
            (root.child[1].child).Add(NewNode('G'));
            (root.child[1].child[0].child).Add(NewNode('H'));
            (root.child[1].child[1].child).Add(NewNode('I'));
            (root.child[1].child[1].child).Add(NewNode('J'));
            (root.child[1].child[1].child[0].child).Add(NewNode('K'));

            Console.WriteLine("The depth of the structure is : " + DepthOfTree(root));
        }
    }
}
