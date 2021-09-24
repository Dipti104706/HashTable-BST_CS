using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_BST_CS
{/// <summary>
/// UC1 to check frequency of words of a given sentence
/// </summary>
/// <typeparam name="K"></typeparam>
/// <typeparam name="V"></typeparam>
    public class MyMapNode<K, V> 
    {
        //this method is for passing Keyvalues in linkedlist, m,n are data types
        public struct KeyValue<m, n>
        {
            public m Key { get; set; }
            public n Value { get; set; }
        }
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        //Constructor to initialize 
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        //Method to find the position of the hash table(creating hash code)
        protected int GetArrayPosition(K Key)
        {
            int hash = Key.GetHashCode();
            int position = hash % size;
            return Math.Abs(position);
        }

        //method to get a value stored in perticular key
        public V Get(K Key)
        {
            int position = GetArrayPosition(Key);

            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(Key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        //Add method for insert value in hashtable
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            //object of keyvalue
            //object initialization(declaration and initialiation at a one time)
            //It doesnot invoke constructor
            KeyValue<K, V> item = new KeyValue<K, V>()
            //assign values to Key and Value
            { Key = key, Value = value };
            if (linkedList.Count != 0)
            {
                foreach (KeyValue<K, V> item1 in linkedList)
                {
                    if (item1.Key.Equals(key))
                    {
                        Remove(key);
                        break;
                    }
                }
            }
            linkedList.AddLast(item);
        }

        //method to create a linkedlist,store values in it 
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }

        //method to display frequencies of word
        public void CountFrequency(string sentence)
        {
            MyMapNode<string, int> myHashTable = new MyMapNode<string, int>(10);
            string[] words = sentence.ToLower().Split(' ');
            foreach (string word in words)
            {
                if (myHashTable.ExistKey(word))
                {
                    myHashTable.Add(word, myHashTable.Get(word) + 1);
                }
                else
                {
                    myHashTable.Add(word, 1);
                }
            }
            Console.WriteLine("Displaying the frequencies of words");
            myHashTable.Display();
        }

        //check key present or not
        public bool ExistKey(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        public void Display()
        {
            foreach (var linkedList in items)
            {
                if (linkedList != null)
                    foreach (var element in linkedList)
                    {
                        string res = element.ToString();
                        if (res != null)
                            Console.WriteLine(element.Key + " " + element.Value);
                    }
            }
        }
    }
}
