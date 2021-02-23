using Library.Nodes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Trees
{
    public class AVLTree<T>: BinaryTree<T> where T : IComparable<T>
    {
        protected new AVLTreeNode<T> _root;

        public AVLTree()
        {

        }

        public AVLTree(AVLTreeNode<T> root)
        {
            _root = root;
        }

        public new AVLTreeNode<T> Root
        {
            get
            {
                return _root;
            }
        }

        public virtual int MaxHeight
        {
            get
            {
                return GetHeight(Root);
            }
        }

        public virtual int MinHeight
        {
            get
            {
                return GetMinHeight(Root);
            }
        }

        public virtual int Balance
        {
            get
            {
                return MaxHeight - MinHeight;
            }
        }

        public AVLTreeNode<T> Search(AVLTreeNode<T> root, T item)
        {
            if(root == null)
            {
                return null;
            }

            else if(root.Item.CompareTo(item) == 0)
            {
                return root;
            }

            else if(root.Item.CompareTo(item) == -1 )
            {
                return Search(root.LeftChild, item);
            }
            else
            {
                return Search(root.RightChild, item);
            }
        }

        public virtual int GetMinHeight(AVLTreeNode<T> root)
        {
            if(root.LeftChild == null || root.RightChild == null)
            {
                return 0;
            }

            else
            {
                int leftHeight = GetHeight(root.LeftChild) + 1;
                int rightHeight = GetHeight(root.RightChild) + 1;

                if(leftHeight < rightHeight)
                {
                    return leftHeight;
                }

                else
                {
                    return rightHeight;
                }
            }
        }

        public virtual void Insert(T item)
        {
            if(_root == null)
            {
                _root = new AVLTreeNode<T>(item);
            }
            else
            {
                Root.Insert(Root, item);
                GetHeight(Root);
                GetMinHeight(Root);
                AVLTreeNode<T> insertedNodeParent = Search(Root, item).Parent;

                if(Balance > 1)
                {
                    if(item.CompareTo(insertedNodeParent.LeftChild.Item) == -1)
                    {
                        RotateRight(insertedNodeParent);
                    }

                    if(item.CompareTo(insertedNodeParent.LeftChild.Item) == 1)
                    {
                        insertedNodeParent.LeftChild = RotateLeft(insertedNodeParent.LeftChild);
                        RotateRight(insertedNodeParent);
                    }

                    if(item.CompareTo(insertedNodeParent.RightChild.Item) == 1)
                    {
                        RotateLeft(insertedNodeParent);
                    }

                    if(item.CompareTo(insertedNodeParent.RightChild.Item) == 1)
                    {
                        insertedNodeParent.RightChild = RotateRight(insertedNodeParent.RightChild);
                        RotateLeft(insertedNodeParent);
                    }
                }
            }
        }

        public virtual AVLTreeNode<T> RotateLeft(AVLTreeNode<T> parent) 
        {
            AVLTreeNode<T> node = parent.RightChild;
            AVLTreeNode<T> otherNode = node.LeftChild;
            node.LeftChild = node;
            parent.RightChild = otherNode;

            GetHeight(Root);
            GetMinHeight(Root);

            return node;
        }

        public virtual AVLTreeNode<T> RotateRight(AVLTreeNode<T> parent)
        {
            AVLTreeNode<T> node = parent.LeftChild;
            AVLTreeNode<T> otherNode = node.RightChild;
            node.RightChild = node;
            parent.LeftChild = otherNode;

            GetHeight(Root);
            GetMinHeight(Root);

            return node;
        }
    }
}
