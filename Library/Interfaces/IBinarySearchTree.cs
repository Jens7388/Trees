using Library.Nodes;


namespace Library.Interfaces
{
    public interface IBinarySearchTree<T>: INonLinearDataStructure<T>
    {

        public BinarySearchTreeNode Root
        {
            get;
        }

        public void Insert(int item);
    }
}
