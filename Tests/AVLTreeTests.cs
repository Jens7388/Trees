using Library.Nodes;
using Library.Trees;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

namespace Tests
{
    public class AVLTreeTests
    {

        [Fact]
        public void TestCreation()
        {
            AVLTree<int> tree = new();
            AVLTree<int> otherTree = new(new AVLTreeNode<int>(5));
        }

        [Fact]
        public void TestInsertions()
        {
            AVLTree<int> tree = new();
            tree.Insert(10);
            tree.Insert(20);
            tree.Insert(30);
            tree.Insert(40);
            tree.Insert(50);
            tree.Insert(25);
        }
    }
}
