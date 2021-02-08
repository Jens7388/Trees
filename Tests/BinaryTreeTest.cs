using Library;

using System;

using Xunit;

namespace Tests
{
    public class BinaryTreeTest
    {
        [Fact]
        public void TestCreation()
        {
            BinaryTreeNode<int> root = new(2);
            BinaryTree<int> tree = new(root);
        }
    }
}
