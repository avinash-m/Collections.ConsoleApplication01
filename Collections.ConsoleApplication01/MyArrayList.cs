using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ConsoleApplication01
{
    static class MyArrayList
    {
        private static ArrayList stringArrayList = new ArrayList();

        public static void AddElements()
        {
            stringArrayList.AddRange(new string[] {"Alabama","Georgia","Iowa" });
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
            foreach (string s in stringArrayList)
            {
                Console.WriteLine(s);
            }
        }

    }
}
