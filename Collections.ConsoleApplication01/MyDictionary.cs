using System;
using System.Collections.Generic;

namespace Collections.ConsoleApplication01
{
    static class MyDictionary
    {
        private static Dictionary<string, double> items = new Dictionary<string, double>();

        public static void AddElements()
        {
            items.Add("cent",0.01D);
            items.Add("nickel", 0.05D);
            items.Add("dime", 0.1D);
            items.Add("quarter", 0.50D);

        }

        public static void RemoveElement(string key)
        {
            if (items.ContainsKey(key))
            { items.Remove(key); }
        }
        public static void UpdateElement(string key)
        {
            if (items.ContainsKey(key))
            {
                items[key] = 0.25D;
            }
        }
        public static int CountElements()
        {
            return items.Count;
        }

        public static void ShowItems()
        {
            foreach (KeyValuePair<string, double> item in items)
            {
                Console.WriteLine($"Key: {item.Key, -10}\tValue: {item.Value, 5}");
            }
        }
    }
}
