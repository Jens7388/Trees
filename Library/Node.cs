using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Node<T>
    {
        private T _item;
        public Node()
        {

        }

        public Node(T item)
        {
            _item = item;
        }

        public T Item
        {
            get
            {
                return _item;
            }
        }
    }
}
