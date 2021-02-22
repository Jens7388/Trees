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
    }
}
