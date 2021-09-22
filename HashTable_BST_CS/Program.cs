using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_BST_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> myMapNode = new MyMapNode<string, string>(6);
            myMapNode.Add("1", "To");
            myMapNode.Add("2", "be");
            myMapNode.Add("3", "or");
            myMapNode.Add("4", "not");
            myMapNode.Add("5", "to");
            myMapNode.Add("6", "be");
            //Console.WriteLine("Getting values by using {0}:{1}","4",myMapNode.Get("4"));
            myMapNode.Display();
            Console.WriteLine(myMapNode.CountFrequency("be"));
            Console.ReadLine();
        }
    }
}
