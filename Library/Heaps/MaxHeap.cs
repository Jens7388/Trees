using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Heaps
{
    public class MaxHeap<T>: BinaryTree<T> where T : IComparable<T>
    {
        protected List<BinaryTreeNode<T>> items;
        protected int count;

        public MaxHeap()
        {
            items = new List<BinaryTreeNode<T>>();
        }

        public MaxHeap(BinaryTreeNode<T> root)
        {
            items = new List<BinaryTreeNode<T>>();
            items[0] = root;
        }

        public List<BinaryTreeNode<T>> Items
        {
            get
            {
                return items;
            }
        }

        public override BinaryTreeNode<T> Root
        {
            get
            {
                return items[0];
            }
        }

        public override int Count
        {
            get
            {
                return items.Count;
            }
        }

        public virtual void Insert(BinaryTreeNode<T> node)
        {
            int i = count - 1;
            items[i] = node;
            while(i > 0 && items[i].Item.CompareTo(items[i / 2].Item) == 1)
            {
                (items[i], items[i / 2]) = (items[i / 2], items[i]);
                i /= 2;
            }
        }

        public virtual BinaryTreeNode<T> Extract(int index)
        {
            if(index <= count)
            {
                BinaryTreeNode<T> extractedNode = items[index];
                items.Remove(items[index]);
                return extractedNode;
            }
            else
            {
                return null;
            }        
        }

        public virtual BinaryTreeNode<T> Search(int index) 
        {
            if(index <= count)
            {
                return items[index];
            }
            else
            {
                return null;
            }
        }

        public virtual void Delete()
        {
            Items.RemoveAll(null!);
        }

        public void Heapify(List<T> items)
        {
            //TODO!
        }
    }
}
