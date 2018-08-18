using System;
using System.Collections;

namespace Collections.ConsoleApplication01
{
    static class MyArrayList
    {
        private static ArrayList stringArrayList = new ArrayList();

        public static void AddElements()
        {
            stringArrayList.AddRange(new string[] {"Alabama","Georgia","Iowa" });

            // Boxing 
            object obj = 45;
            stringArrayList.Add(obj);
        }

        public static void RemoveElement(int position)
        {
            if (position < stringArrayList.Count)
            { stringArrayList.RemoveAt(position); }
        }
        public static void UpdateElement(int position)
        {
            if (position < stringArrayList.Count)
            {
                stringArrayList[position] = "Florida"; 
            }
        }
        public static int CountElements()
        {
            return stringArrayList.Count;
        }

        public static void ShowItems()
        {
            foreach (object o in stringArrayList)
            {
                Console.WriteLine(o);
            }
        }

    }
}
