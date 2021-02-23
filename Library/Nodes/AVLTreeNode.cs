using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Nodes
{
    public class AVLTreeNode<T>: BinaryTreeNode<T> where T : IComparable<T>
    {
        protected new AVLTreeNode<T> _leftChild;
        protected new AVLTreeNode<T> _rightChild;
        protected new AVLTreeNode<T> _parent;

        public AVLTreeNode()
        {

        }

        public AVLTreeNode(T item)
        {
            _item = item;
        }

        public virtual void Insert(AVLTreeNode<T> root, T item)
        {
            if(Item.CompareTo(item) > 0)
            {
                if(LeftChild == null)
                {
                    AddLeftChild(item);
                    LeftChild.Parent = root;
                }

                else
                {
                    LeftChild.Insert(LeftChild, item);
                }
            }

            else if(Item.CompareTo(item) < 0)
            {
                if(RightChild == null)
                {
                    AddRightChild(item);
                    RightChild.Parent = root;
                }

                else
                {
                    RightChild.Insert(RightChild, item);
                }
            }
        }

        public new virtual AVLTreeNode<T> LeftChild
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

        public new virtual AVLTreeNode<T> RightChild
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

        public virtual new AVLTreeNode<T> Parent
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
    }
}
