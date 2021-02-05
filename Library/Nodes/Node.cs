using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Node<T>
    {
        protected T _item;

        public Node()
        {

        }

        public Node(T item)
        {
            _item = item;
        }

        public virtual T Item
        {
            get
            {
                return _item;
            }
        }
    }
}
