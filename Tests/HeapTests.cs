using Library;
using Library.Heaps;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace Tests
{
    public class HeapTests
    {
        [Fact]
        public void TestCreation()
        {
            MaxHeap<int> maxHeap = new(new BinaryTreeNode<int>(5));
            MinHeap<int> minHeap = new(new BinaryTreeNode<int>(5));
        }

        [Fact]
        public void TestInsertionOnEmpty()
        {
            MaxHeap<int> maxHeap = new();
            maxHeap.Insert(new BinaryTreeNode<int>(5));
            MinHeap<int> minHeap = new();
            minHeap.Insert(new BinaryTreeNode<int>(5));
        }

        [Fact]
        public void TestMaxHeapInsertions()
        {
            MaxHeap<int> maxHeap = new();
            maxHeap.Insert(new BinaryTreeNode<int>(20));
            maxHeap.Insert(new BinaryTreeNode<int>(19));
            maxHeap.Insert(new BinaryTreeNode<int>(17));
            maxHeap.Insert(new BinaryTreeNode<int>(18));
            maxHeap.Insert(new BinaryTreeNode<int>(12));
            maxHeap.Insert(new BinaryTreeNode<int>(14));
            maxHeap.Insert(new BinaryTreeNode<int>(25));
            maxHeap.Insert(new BinaryTreeNode<int>(13));
            maxHeap.Insert(new BinaryTreeNode<int>(22));
            maxHeap.Insert(new BinaryTreeNode<int>(11));
            maxHeap.Insert(new BinaryTreeNode<int>(5));
            maxHeap.Insert(new BinaryTreeNode<int>(3));
        }
    }
}
