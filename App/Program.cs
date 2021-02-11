using Library.Nodes;
using Library.Trees;

using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main()
        {
            BinarySearchTree<int> tree = new();
            tree.Insert(3);
            tree.Insert(1);
            tree.InsertMany(new List<int> {6, 2, 4});
            Print(tree);
        }

        public static void Print(BinarySearchTree<int> tree)
        {
            Console.WriteLine(tree.InOrder(tree.Root));
        }
    }
}
