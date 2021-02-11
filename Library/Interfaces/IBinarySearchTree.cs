using Library.Nodes;


namespace Library.Interfaces
{
    public interface IBinarySearchTree<T>: INonLinearDataStructure<T>
    {
        public void Insert(T item);
    }
}
