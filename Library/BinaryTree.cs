using Library.Interfaces;

using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class BinaryTree<T>: IBinaryTree<T>
    {
        private BinaryTreeNode<T> _root;

        public BinaryTree(BinaryTreeNode<T> root)
        {
            _root = root;
        }

        public BinaryTreeNode<T> Root
        {
            get
            {
                return _root;
            }
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void AddLeftChildTo(BinaryTreeNode<T> parent, T leftChildItem)
        {
            throw new NotImplementedException();
        }

        public void AddRightChildTo(BinaryTreeNode<T> parent, T rightChildItem)
        {
            throw new NotImplementedException();
        }

        public int GetHeight(BinaryTreeNode<T> root)
        {
            throw new NotImplementedException();
        }

        public string ToStringLevel(int level, BinaryTreeNode<T> root)
        {
            throw new NotImplementedException();
        }

        public int ToStringLevelOrder()
        {
            throw new NotImplementedException();
        }
    }
}
