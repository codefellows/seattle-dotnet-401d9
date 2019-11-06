using System;
using System.Collections.Generic;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tree();
        }

        static void Tree()
        {
            #region tree Construction
            Tree<int> tree = new Tree<int>(4);

            Node<int> node2 = new Node<int>(8);
            Node<int> node3 = new Node<int>(15);
            Node<int> node4 = new Node<int>(16);
            Node<int> node5 = new Node<int>(23);
            Node<int> node6 = new Node<int>(42);
            Node<int> node7 = new Node<int>(108);

            tree.Root.LeftChild = node2;
            tree.Root.RightChild = node3;
            node2.LeftChild = node4;
            node2.RightChild = node5;
            node3.LeftChild = node6;
            node3.RightChild = node7;

            #endregion

            List<int> preOrder = tree.PreOrder(tree.Root);
            Console.WriteLine("======== PRE-ORDER =======");
            Console.WriteLine(string.Join(',', preOrder));
            Console.WriteLine();



            List<int> postOrder = tree.PostOrder(tree.Root);
            Console.WriteLine("======== POST-ORDER =======");
            Console.WriteLine(string.Join(',', postOrder));
            Console.WriteLine();


            List<int> inOrder = tree.InOrder(tree.Root);
            Console.WriteLine("======== IN-ORDER =======");

            Console.WriteLine(string.Join(',', inOrder));
            Console.WriteLine();


            List<int> breadth = tree.BreadthFirst(tree.Root);
            Console.WriteLine("======== BREADTH-FIRST =======");

            Console.WriteLine(string.Join(',', breadth));





        }
    }
}
