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

        [Fact]
        public void TestChildAdditions()
        {
            BinaryTreeNode<int> root = new(2);
            BinaryTree<int> tree = new(root);
            tree.AddLeftChildTo(root, 1);
            tree.AddRightChildTo(root, 1);
            tree.AddLeftChildTo(root.LeftChild, 1);
            tree.AddRightChildTo(root.RightChild, 1);
            tree.AddRightChildTo(root.RightChild.RightChild, 1);
        }
        
        [Fact]
        public void TestCount()
        {
            BinaryTreeNode<int> root = new(2);
            BinaryTree<int> tree = new(root);
            tree.AddLeftChildTo(root, 1);
            tree.AddRightChildTo(root, 1);
            tree.AddLeftChildTo(root.LeftChild, 1);
            tree.AddRightChildTo(root.RightChild, 1);
            tree.AddRightChildTo(root.RightChild.RightChild, 1);           
            Assert.True(tree.Count == 6);
        }
    }
}