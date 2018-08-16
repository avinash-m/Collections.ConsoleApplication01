using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections.ConsoleApplication01
{
    class MyHashTable
    {
        private static Hashtable hashTableItems = new Hashtable();

        public static void AddElements()
        {
            hashTableItems.Add("white", 5);
            hashTableItems.Add("orange", 6);
            hashTableItems.Add("green", 9);
        }

        public static void RemoveElement(string key)
        {
            if (hashTableItems.ContainsKey(key))
            { hashTableItems.Remove(key); }
        }
        public static void UpdateElement(string key)
        {
            if (hashTableItems.ContainsKey(key))
            {
                hashTableItems[key] = 20;
            }
        }
        public static int CountElements()
        {
            return hashTableItems.Count;
        }

        public static void ShowHashTableItems()
        {
            foreach (string key in hashTableItems.Keys)
            {
                Console.WriteLine($"Key: {key,-10}\tValue: {hashTableItems[key],5}");
            }
        }
    }
}
