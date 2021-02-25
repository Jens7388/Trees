﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Trees
{
    public class BinaryIndexTree
    {
        protected int[] nodes;
        protected int length;

        public BinaryIndexTree(int length){
            nodes = new int[length];
        }

        public virtual int TotalSum
        {
            get
            {
                return GetSum(Length);
            }
        }

        public virtual int Length
        {
            get
            {
                return length;
            }
        }

        public virtual int[] Nodes
        {
            get
            {
                return nodes;
            }
        }

        /* n --> No. of elements present in input array.  
        BITree[0..n] --> Array that represents Binary  
                        Indexed Tree.  
        arr[0..n-1] --> Input array for which prefix sum  
                        is evaluated. */

        // Returns sum of arr[0..index]. This function  
        // assumes that the array is preprocessed and  
        // partial sums of array elements are stored  
        // in BITree[].  
        public virtual int GetSum(int index)
        {
            int sum = 0; // Iniialize result  

            // index in BITree[] is 1 more than  
            // the index in arr[]  
            index += 1;

            // Traverse ancestors of BITree[index]  
            while(index > 0)
            {
                // Add current element of BITree  
                // to sum  
                sum += Nodes[index];

                // Move index to parent node in  
                // getSum View  
                index -= index & (-index);
            }
            return sum;
        }

        // Updates a node in Binary Index Tree (BITree)  
        // at given index in BITree. The given value  
        // 'val' is added to BITree[i] and all of  
        // its ancestors in tree.  
        public virtual void UpdateTree(int n, int index,
                                            int val)
        {
            // index in BITree[] is 1 more than  
            // the index in arr[]  
            index += 1;

            // Traverse all ancestors and add 'val'  
            while(index <= n)
            {

                // Add 'val' to current node of BIT Tree  
                Nodes[index] += val;

                // Update index to that of parent  
                // in update View  
                index += index & (-index);
            }
        }

        /* Function to construct fenwick tree  
        from given array.*/
         public virtual void ConstructTree(int[] arr, int n)
        {
            // Initialize BITree[] as 0  
            for(int i = 1; i <= n; i++)
            {
                Nodes[i] = 0;
            }

            // Store the actual values in BITree[]  
            // using update()  
            for(int i = 0; i < n; i++)
            {
                UpdateTree(n, i, arr[i]);
            }
        }
    }
}