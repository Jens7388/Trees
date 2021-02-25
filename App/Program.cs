using Library.Nodes;
using Library.Trees;

using System;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main()
        {/*
            BinarySearchTree<int> tree = new();
            tree.Insert(3);
            tree.Insert(1);
            tree.InsertMany(new List<int> {6, 2, 4});
            Print(tree);*/

            int[] array = {2, 1, 1, 3, 2, 3,
                    4, 5, 6, 7, 8, 9};
            int n = array.Length;
            BinaryIndexTree tree = new BinaryIndexTree(100);
            tree.ConstructTree(array, n);

            Console.WriteLine("Sum of elements in arr[0..5]" +
                            " is " + tree.GetSum(5));
            array[3] += 6;
            tree.UpdateTree(n, 3, 6);
            Console.WriteLine("Sum of elements in arr[0..5]" +
                        " after update is " + tree.GetSum(5));
        }

        public static void Print(BinarySearchTree<int> tree)
        {
            Console.WriteLine(tree.InOrder(tree.Root));
        }
    }
}
