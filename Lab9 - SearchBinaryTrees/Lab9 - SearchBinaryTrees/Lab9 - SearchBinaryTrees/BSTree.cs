using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9___SearchBinaryTrees
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {
        public BSTree()
        {
            root = null;
        }

        public BSTree(Node<T> node)
        {
            root = node;
        }

        private void insertItem(T item, ref Node<T> tree)
        //insert item into tree
        {
            if (tree == null)
                tree = new Node<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        protected int treeHeight(Node<T> tree)
        //returns max level of the tree
        {
            if (tree == null)
                return 0;
            else
                return Math.Max(treeHeight(tree.Left), treeHeight(tree.Right)) + 1;
        }

        public void Height()
        {
            Console.WriteLine(treeHeight(root));
        }

        private int treeCount(Node<T> tree)
        //returns the number of nodes in the tree
        {
            int left = 0;
            int right = 0;
            int total = 1;

            if (tree == null)
                return 0;
            if (tree.Left != null)
                left = treeCount(tree.Left);
            if (tree.Right != null)
                right = treeCount(tree.Right);
            return (left + right) + total;
        }

        public void Count()
        {
            Console.WriteLine(treeCount(root));
        }

        private Boolean treeContains(T item, Node<T> tree)
        //returns true if the item is contained in the BSTree, false otherwise
        {
            if (tree == null)
                return false;
            if (tree.Data.CompareTo(item) == 0)
                return true;
            else
            {
                if (tree.Data.CompareTo(item) > 0)
                    return treeContains(item, tree.Left);
                else
                    return treeContains(item, tree.Right);
            }
        }

        public void Contains(T item)
        {
            Console.WriteLine(treeContains(item, root));
        }

        private T leastItem(Node<T> tree)
        {
            if (tree.Left == null)
            {
                return tree.Data;
            }
            else return leastItem(tree.Left);
        }

        public void removeItem(T item, ref Node<T> tree)
        //removes item from the tree
        {
            if (tree != null)
            {
                if (item.CompareTo(tree.Data) < 0)
                    removeItem(item, ref tree.Left);

                if (item.CompareTo(tree.Data) > 0)
                    removeItem(item, ref tree.Right);

                if (tree.Data.CompareTo(item) == 0)
                {
                    if (tree.Left == null && tree.Right == null) //no sub tree
                    {
                        Console.WriteLine("No Child Node");
                    }
                    else if (tree.Right == null && tree.Left != null) //left sub tree
                    {
                        Console.WriteLine("Moved Left Child Node");
                        tree = tree.Left;
                    }
                    else if (tree.Left == null && tree.Right != null) //right sub tree
                    {
                        Console.WriteLine("Moved Right Child Node");
                        tree = tree.Right;
                    }
                    else if (tree.Left != null && tree.Right != null) //2 sub trees
                    {
                        Console.WriteLine("Moved Left & Right Child Nodes");
                        T newRoot = leastItem(tree.Right);
                        tree.Data = newRoot;
                        removeItem(newRoot, ref tree.Right);
                    }
                }
            }
            else
                Console.WriteLine("Item Not Found");
        }

        public void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }
    }
}