using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class BinaryTreeNode<T>: TreeNode<T>
    {
        private BinaryTreeNode<T> _leftChild;
        private BinaryTreeNode<T> _rightChild;

        public BinaryTreeNode()
        {

        }

        public BinaryTreeNode(T item)
        {
            _item = item;
        }

        public void AddLeftChild(T item)
        {
            //TODO
        }

        public void AddRightChild(T item)
        {
            //TODO
        }

        public BinaryTreeNode<T> LeftChild
        {
            get
            {
                return _leftChild;
            }
        }

        public BinaryTreeNode<T> RightChild
        {
            get
            {
                return _rightChild;
            }
        }
    }
}
