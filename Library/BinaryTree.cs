﻿using Library.Interfaces;

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
                return GetCount(_root, 1);
            }
        }

        public int GetCount(BinaryTreeNode<T> node, int count)
        {
            if(node.LeftChild != null && node.RightChild != null)
            {
                count += GetCount(node.LeftChild, count) + GetCount(node.RightChild, count);
            }
            else if(node.LeftChild != null && node.RightChild == null)
            {
                count += GetCount(node.LeftChild, count);
            }
            else if(node.LeftChild == null && node.RightChild != null)
            {
                count += GetCount(node.RightChild, count);
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
            if(root == null)
            {
                return 0;
            }
            else
            {
                int leftHeight = GetHeight(root.LeftChild) + 1;
                int rightHeight = GetHeight(root.RightChild) + 1;
                if(leftHeight > rightHeight)
                {
                    return leftHeight;
                }
                else
                {
                    return rightHeight;
                }
            }
        }

        public string ToStringLevel(int level, BinaryTreeNode<T> root)
        {
            string toReturn = "";
            if(root == null)
            {
                return "";
            }
            if(level == 1)
            {
                toReturn += root.ToString() + " ";
                return toReturn;
            }
            else if(level > 1)
            {
                toReturn += ToStringLevel(level - 1, root.LeftChild);
                toReturn += ToStringLevel(level - 1, root.RightChild);
            }
            return toReturn;
        }   

        public string ToStringLevelOrder()
        {
            int length = GetHeight(Root);
            string tree ="";
            for(int i = 0; i <= length; i++)
            {
                tree += ToStringLevel(i, Root);
            }

            return tree;
        }

        public string PostOrder(BinaryTreeNode<T> node)
        {
            string toReturn = "";
            if(node != null)
            {
                toReturn += PostOrder(node.LeftChild);
                toReturn += PostOrder(node.RightChild);
                toReturn += node + " ";
            }

            return toReturn;
        }

        public string InOrder(BinaryTreeNode<T> node)
        {
            string toReturn = "";
            if(node.LeftChild != null)
            {              
                toReturn += InOrder(node.LeftChild);
            }

            toReturn += node + " ";

            if(node.RightChild != null)
            {
                toReturn += InOrder(node.RightChild);
            }    

            return toReturn;
        }

        public string PreOrder(BinaryTreeNode<T> node)
        {
            string toReturn = "";
            
            if(node != null)
            {
                toReturn += node + " ";
                toReturn += PreOrder(node.LeftChild);
                toReturn += PreOrder(node.RightChild);
            }
                           
            return toReturn;
        }
    }
}
