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
            MyMapNode<string, int> hash1 = new MyMapNode<string, int>(10);
            hash1.CountFrequency("Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations");
            Console.ReadLine();
        }
    }
}
