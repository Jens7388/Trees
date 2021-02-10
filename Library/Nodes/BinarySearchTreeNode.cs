using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Nodes
{
    public class BinarySearchTreeNode : TreeNode<int>
    {
        protected BinarySearchTreeNode _leftChild;
        protected BinarySearchTreeNode _rightChild;

        public BinarySearchTreeNode()
        {

        }

        public BinarySearchTreeNode(int item)
        {
            _item = item;
        }

        public virtual void Insert(int item)
        {
            if(Item > item)
            {
                if(LeftChild == null)
                {
                    _leftChild = new BinarySearchTreeNode(item);
                }

                else
                {
                    LeftChild.Insert(item);
                }
            }

            else if (Item < item)
            {
                if(RightChild == null)
                {
                    _rightChild = new BinarySearchTreeNode(item);
                }

                else
                {
                    RightChild.Insert(item);
                }
            }
        }

        public virtual BinarySearchTreeNode LeftChild
        {
            get
            {
                return _leftChild;
            }
        }

        public virtual BinarySearchTreeNode RightChild
        {
            get
            {
                return _rightChild;
            }
        }
    }
}
