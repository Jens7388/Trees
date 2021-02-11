using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Nodes
{
    public class BinarySearchTreeNode<T> : TreeNode<T> where T: IComparable<T>
    {
        protected BinarySearchTreeNode<T> _leftChild;
        protected BinarySearchTreeNode<T> _rightChild;

        public BinarySearchTreeNode()
        {

        }

        public BinarySearchTreeNode(T item)
        {
            _item = item;
        }

        public virtual void Insert(T item)
        {
            if(Item.CompareTo(item) > 0)
            {
                if(LeftChild == null)
                {
                    _leftChild = new BinarySearchTreeNode<T>(item);
                }

                else
                {
                    LeftChild.Insert(item);
                }
            }

            else if (Item.CompareTo(item) < 0)
            {
                if(RightChild == null)
                {
                    _rightChild = new BinarySearchTreeNode<T>(item);
                }

                else
                {
                    RightChild.Insert(item);
                }
            }
        }

        public virtual BinarySearchTreeNode<T> LeftChild
        {
            get
            {
                return _leftChild;
            }
        }

        public virtual BinarySearchTreeNode<T> RightChild
        {
            get
            {
                return _rightChild;
            }
        }
    }
}
