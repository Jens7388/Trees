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
        public void TestSearch()
        {
            BinaryTreeNode<int> root = new(2);
            BinaryTree<int> tree = new(root);
            tree.AddLeftChildTo(root, 1);
            tree.AddRightChildTo(root, 2);
            tree.AddLeftChildTo(root.LeftChild, 3);
            tree.AddRightChildTo(root.LeftChild, 5);
            tree.AddLeftChildTo(root.LeftChild.LeftChild, 8);
            tree.AddLeftChildTo(root.LeftChild.LeftChild.LeftChild, 9);
            tree.AddRightChildTo(root.RightChild, 4);
            Assert.True(tree.Search(root, 5) != null);
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

        [Fact]
        public void TestHeight()
        {
            BinaryTreeNode<int> root = new(2);
            BinaryTree<int> tree = new(root);
            tree.AddLeftChildTo(root, 1);
            tree.AddRightChildTo(root, 1);
            tree.AddLeftChildTo(root.LeftChild, 1);
            tree.AddRightChildTo(root.RightChild, 1);
            tree.AddRightChildTo(root.RightChild.RightChild, 1);
            Assert.True(tree.GetHeight(tree.Root) == 4);
        }

        [Fact]
        public string TestToStringLevel()
        {
            BinaryTreeNode<int> root = new(2);
            BinaryTree<int> tree = new(root);
            tree.AddLeftChildTo(root, 1);
            tree.AddRightChildTo(root, 1);
            tree.AddLeftChildTo(root.LeftChild, 1);
            tree.AddRightChildTo(root.RightChild, 1);
            tree.AddLeftChildTo(root.RightChild.RightChild, 1);
            tree.AddLeftChildTo(root.LeftChild.LeftChild, 1);
            tree.AddRightChildTo(root.RightChild.RightChild, 2);
            return tree.ToStringLevel(4, tree.Root);
        }

        [Fact]
        public string TestToStringLevelOrder()
        {
            BinaryTreeNode<int> root = new(2);
            BinaryTree<int> tree = new(root);
            tree.AddLeftChildTo(root, 1);
            tree.AddRightChildTo(root, 1);
            tree.AddLeftChildTo(root.LeftChild, 1);
            tree.AddRightChildTo(root.RightChild, 1);
            tree.AddLeftChildTo(root.RightChild.RightChild, 2);
            return tree.ToStringLevelOrder();
        }

        [Fact]
        public string TestPostOrder()
        {
            BinaryTreeNode<int> root = new(1);
            BinaryTree<int> tree = new(root);
            tree.AddLeftChildTo(root, 2);
            tree.AddRightChildTo(root, 3);
            tree.AddLeftChildTo(root.LeftChild, 4);
            tree.AddRightChildTo(root.LeftChild, 5);
            return tree.PostOrder(root);
        }

        [Fact]
        public string TestInOrder()
        {
            BinaryTreeNode<int> root = new(1);
            BinaryTree<int> tree = new(root);
            tree.AddLeftChildTo(root, 2);
            tree.AddRightChildTo(root, 3);
            tree.AddLeftChildTo(root.LeftChild, 4);
            tree.AddRightChildTo(root.LeftChild, 5);
            return tree.InOrder(root);
        }

        [Fact]
        public string TestPreOrder()
        {
            BinaryTreeNode<int> root = new(1);
            BinaryTree<int> tree = new(root);
            tree.AddLeftChildTo(root, 2);
            tree.AddRightChildTo(root, 3);
            tree.AddLeftChildTo(root.LeftChild, 4);
            tree.AddRightChildTo(root.LeftChild, 5);
            return tree.PreOrder(root);
        }
    }
}
