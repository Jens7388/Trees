using Library.Interfaces;
using Library.Nodes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Trees
{
    public class BinarySearchTree<T>: IBinarySearchTree<T>
    {
        protected BinarySearchTreeNode _root;

        public BinarySearchTree()
        {

        }

        public BinarySearchTree(BinarySearchTreeNode root)
        {
            _root = root;
        }

        public virtual BinarySearchTreeNode Root
        {
            get
            {
                return _root;
            }
        }

        public virtual int Count
        {
            get
            {
                return GetCount(Root, 0);
            }
        }

        public virtual int GetCount(BinarySearchTreeNode node, int count)
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

        public virtual void Insert(int item)
        {
            if(_root == null)
            {
                _root = new BinarySearchTreeNode(item);
            }
            else
            {
                Root.Insert(item);
            }
        }
    }
}
