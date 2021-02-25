using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Nodes
{
    public class AVLTreeNode<T>: TreeNode<T> where T : IComparable<T>
    {
        protected AVLTreeNode<T> _leftChild;
        protected AVLTreeNode<T> _rightChild;
        protected new AVLTreeNode<T> _parent;

        public AVLTreeNode()
        {

        }

        public AVLTreeNode(T item)
        {
            _item = item;
        }

        public virtual AVLTreeNode<T> LeftChild
        {
            get
            {
                return _leftChild;
            }
            set
            {
                _leftChild = value;
            }
        }

        public virtual AVLTreeNode<T> RightChild
        {
            get
            {
                return _rightChild;
            }
            set
            {
                _rightChild = value;
            }
        }

        public new virtual AVLTreeNode<T> Parent
        {
            get
            {
                return _parent;
            }
            set
            {
                _parent = value;
            }
        }

        public virtual void Insert(AVLTreeNode<T> root, T item)
        {
            if(Item.CompareTo(item) > 0)
            {
                if(LeftChild == null)
                {
                    AddLeftChild(item);
                    root.LeftChild.Parent = root;
                }

                else
                {
                    root.LeftChild.Insert(LeftChild, item);
                }
            }

            else if(Item.CompareTo(item) < 0)
            {
                if(RightChild == null)
                {
                    AddRightChild(item);
                    root.RightChild.Parent = root;
                }

                else
                {
                    root.RightChild.Insert(RightChild, item);
                }
            }
        }

        public virtual void AddLeftChild(T item)
        {
            if(_leftChild == null)
            {
                _leftChild = new AVLTreeNode<T>(item);
            }
        }

        public virtual void AddRightChild(T item)
        {
            if(_rightChild == null)
            {
                _rightChild = new AVLTreeNode<T>(item);
            }
        }    
    }
}
