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

        public int Count
        {
            get
            {
                return GetCount(_root, 0);
            }
        }

        public int GetCount(BinaryTreeNode<T> node, int count)
        {
            if(node.LeftChild != null && node.RightChild != null)
            {
                count+=2;
                GetCount(node.LeftChild, count);
                GetCount(node.RightChild, count);
            }
            else if(node.LeftChild != null && node.RightChild == null)
            {
                count++;
                GetCount(node.LeftChild, count);
            }
            else if(node.LeftChild == null && node.RightChild != null)
            {
                count++;
                GetCount(node.RightChild, count);
            }
            return count;
        }

        public void AddLeftChildTo(BinaryTreeNode<T> parent, T leftChildItem)
        {
            parent.AddLeftChild(leftChildItem);
        }

        public void AddRightChildTo(BinaryTreeNode<T> parent, T rightChildItem)
        {
            parent.AddRightChild(rightChildItem);
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
