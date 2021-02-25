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
            set
            {
                _root = value;
            }
        }

        public virtual int LeftHeight
        {
            get
            {
                return GetHeight(Root.LeftChild);
            }
        }

        public virtual int RightHeight
        {
            get
            {
                return GetHeight(Root.RightChild);
            }
        }

        public virtual int Balance
        {
            get
            {
                return LeftHeight - RightHeight;
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

            else if(root.Item.CompareTo(item) == 1 )
            {
                return Search(root.LeftChild, item);
            }
            else
            {
                return Search(root.RightChild, item);
            }
        }

        public virtual int GetHeight(AVLTreeNode<T> root)
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

        public virtual void Insert(T item)
        {
            if(_root == null)
            {
                _root = new AVLTreeNode<T>(item);
            }
            else
            {
                Root.Insert(Root, item);
                GetHeight(Root.LeftChild);
                GetHeight(Root.RightChild);
                AVLTreeNode<T> insertedNodeParent = Search(Root, item).Parent;

                if(Balance > 1)
                {
                    //Left left case
                    if(item.CompareTo(insertedNodeParent.Item) == -1)
                    {
                        RotateRight(insertedNodeParent);
                    }

                    //Left right case
                    if(item.CompareTo(insertedNodeParent.Item) == 1)
                    {
                        RotateLeft(insertedNodeParent.LeftChild);
                        RotateRight(insertedNodeParent);
                    }           
                }
                else if (Balance < -1)
                {
                    //Right right case
                    if(item.CompareTo(insertedNodeParent.Item) == 1)
                    {
                        RotateLeft(insertedNodeParent);
                    }

                    //Right left case   
                    else if(item.CompareTo(insertedNodeParent.Item) == -1)
                    {
                        RotateRight(insertedNodeParent.RightChild);
                        RotateLeft(insertedNodeParent);
                    }
                }
            }
        }

        public virtual void RotateLeft(AVLTreeNode<T> root)
        {
            if(root == null)
            {
                return;
            }

            AVLTreeNode<T> pivot = root.RightChild;

            if(pivot == null)
            {
                return;
            }

            else
            {
                AVLTreeNode<T> rootParent = root.Parent; //original parent of root node
                bool isLeftChild = (rootParent != null) && rootParent.LeftChild == root; //whether the root was the parent's left node

                //Rotate
                root.RightChild = pivot.LeftChild;
                pivot.LeftChild = root;

                //Update parents
                root.Parent = pivot;
                pivot.Parent = rootParent;

                if(root.RightChild != null)
                {
                    root.RightChild.Parent = root;
                }

                //Update the entire tree's Root if necessary
                if(rootParent == Root)
                {
                    Root = pivot;
                }

                //Update the original parent's child node
                if(isLeftChild)
                {
                    rootParent.LeftChild = pivot;
                }
                else if(rootParent != null)
                {
                    rootParent.RightChild = pivot;
                }
            }
        }

        public virtual void RotateRight(AVLTreeNode<T> root)
        {
            if(root == null)
            {
                return;
            }

            AVLTreeNode<T> pivot = root.LeftChild;

            if(pivot == null)
            {
                return;
            }
            else
            {
                AVLTreeNode<T> rootParent = root.Parent; //original parent of root node
                bool isLeftChild = (rootParent != null) && rootParent.LeftChild == root; //whether the root was the parent's left node

                //Rotate
                root.LeftChild = pivot.RightChild;
                pivot.RightChild = root;

                //Update parents
                root.Parent = pivot;
                pivot.Parent = rootParent;

                if(root.LeftChild != null)
                {
                    root.LeftChild.Parent = root;
                }

                //Update the entire tree's Root if necessary
                if(root == Root)
                {
                    Root.Item = pivot.Item;
                }

                //Update the original parent's child node
                if(isLeftChild)
                {
                    rootParent.LeftChild = pivot;
                }

                else if(rootParent != null)
                {
                    rootParent.RightChild = pivot;
                }

                GetHeight(Root.LeftChild);
                GetHeight(Root.RightChild);
            }
            }
        }
    }

