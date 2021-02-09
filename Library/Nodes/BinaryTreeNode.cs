using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class BinaryTreeNode<T>: TreeNode<T>
    {
        protected BinaryTreeNode<T> _leftChild;
        protected BinaryTreeNode<T> _rightChild;

        public BinaryTreeNode()
        {

        }

        public BinaryTreeNode(T item)
        {
            _item = item;
        }

        public virtual void AddLeftChild(T item)
        {
            if(_leftChild == null)
            {
                _leftChild = new BinaryTreeNode<T>(item);
            }
        }

        public virtual void AddRightChild(T item)
        {
            if(_rightChild == null)
            {
                _rightChild = new BinaryTreeNode<T>(item);
            }
        }

        public virtual BinaryTreeNode<T> LeftChild
        {
            get
            {
                return _leftChild;
            }
        }

        public virtual BinaryTreeNode<T> RightChild
        {
            get
            {
                return _rightChild;
            }
        }
    }
}
