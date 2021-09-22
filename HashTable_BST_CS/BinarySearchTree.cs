﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_BST_CS
{
    class BinarySearchTree<T> where T : IComparable<T>
    {/// <summary>
    /// UC2 for bst to add element and show size of the BST
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

        int leftCount = 0, rightCount = 0;

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
            Console.WriteLine("The size of the tree is" + " " + (1+this.leftCount + this.rightCount));
        }

        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.RootNode.ToString());
            if (this.RightTree != null)
            {
                this.rightCount++;
                this.RightTree.Display();
            }
        }
    }
}