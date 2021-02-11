using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class TreeNode<T> : Node<T>
    {
        protected TreeNode<T> _parent;

        public TreeNode()
        {

        }

        public TreeNode(T item)
        {
            _item = item;
        }

        public TreeNode(T item, TreeNode<T> parent)
        {
            _parent = parent;
            _item = item;
        }

        public TreeNode(TreeNode<T> parent)
        {
            _parent = parent;
        }

        public virtual TreeNode<T> Parent
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
