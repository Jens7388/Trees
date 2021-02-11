using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Heaps
{
    public class MinHeap<T>: BinaryTree<T> where T: IComparable<T>
    {
        protected BinaryTreeNode<T>[] heapArray;
        protected int count;

        public MinHeap(int size)
        {
            heapArray = new BinaryTreeNode<T>[size]; 
        }

        public MinHeap(BinaryTreeNode<T> root, int size)
        {
            heapArray = new BinaryTreeNode<T>[size];
            heapArray[0] = root;
            _root = heapArray[0];
        }

        public BinaryTreeNode<T>[] HeapArray
        {
            get 
            {
                return heapArray;
            }
        }

        public virtual int GetCount()
        {
            foreach(BinaryTreeNode<T> node in HeapArray)
            {
                if(node != null)
                {
                    count++;
                }
            }
            return count;
        }

        public virtual void Insert(BinaryTreeNode<T> node)
        {
            int i = count;
            if(count == 0)
            {
                heapArray[i] = node;
                _root = node;
                count++;
            }
            
        }

        public virtual BinaryTreeNode<T> Extract(int index)
        {
            if(index <= count)
            {
                BinaryTreeNode<T> extractedNode = heapArray[index];
                heapArray[index] = null;
                if(index != count)
                {
                    for(int i = index; i < count; i++)
                    {
                        heapArray[count - 1] = heapArray[i];
                    }
                }
                count--;
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
                return heapArray[index];
            }
            else
            {
                return null;
            }
        }

        public virtual void Delete()
        {
            for(int i = 0; i < count; i++)
            {
                heapArray[i] = null;
            }
            count = 0;
        }
    }
}
