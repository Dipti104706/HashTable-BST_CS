using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_BST_CS
{
    class BinarySearchTree<T> where T : IComparable<T>
    {/// <summary>
    /// UC3 for bst to search 63 of the binary search tree
    /// </summary>
        public T RootNode { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T RootNode)
        {
            this.RootNode = RootNode;
            this.LeftTree = null;
            this.RightTree = null;
        }

        public static int leftCount = 0, rightCount = 0;
        bool result = false;

        //method for inserting element in binary search tree
        public void Insert(T item)
        {
            T currentNodeValue = this.RootNode;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    this.LeftTree.Insert(item);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new BinarySearchTree<T>(item);
                }
                else
                {
                    this.RightTree.Insert(item);
                }
            }
        }

        //method to give size of the binary search tree
        public void GetSize()
        {
            Console.WriteLine("The size of the tree is" + " " + (1+leftCount +rightCount));
        }

        //method for search node in BST
        public bool Search(T element, BinarySearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.RootNode.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.RootNode);
                result = true;
            }
            //else
            //{
            //    Console.WriteLine("Current element in BST is {0}", node.RootNode);
            //}
            if (element.CompareTo(node.RootNode) < 0)
            {
                Search(element, node.LeftTree);
            }
            if (element.CompareTo(node.RootNode) > 0)
            {
                Search(element, node.RightTree);
            }
            return result;
        }

        public void Display()
        {
            if (this.LeftTree != null)
            {
                leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.RootNode.ToString());
            if (this.RightTree != null)
            {
                rightCount++;
                this.RightTree.Display();
            }
        }
    }
}
