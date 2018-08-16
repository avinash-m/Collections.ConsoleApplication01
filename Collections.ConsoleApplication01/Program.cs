using System;

namespace Collections.ConsoleApplication01
{
    class Program
    {
        static void Main(string[] args)
        {       
            // ArrayList
            Console.WriteLine("Adding items to ArrayList");
            MyArrayList.AddElements();
            Console.WriteLine("Number of items added: " + MyArrayList.CountElements());
            Console.WriteLine("Items in the list:");
            MyArrayList.ShowItems();
            Console.WriteLine("Updating 3rd item");
            MyArrayList.UpdateElement(2);
            MyArrayList.ShowItems();
            Console.WriteLine("Removing 2nd element");
            MyArrayList.RemoveElement(1);
            MyArrayList.ShowItems();
            Console.WriteLine("------------------------");

            // Dictionary
            Console.WriteLine("Adding items to Dictionary");
            MyDictionary.AddElements();
            Console.WriteLine("Number of items added: " + MyDictionary.CountElements());
            Console.WriteLine("Items in the list:");
            MyDictionary.ShowItems();
            Console.WriteLine("Updating 'quarter' value");
            MyDictionary.UpdateElement("quarter");
            MyDictionary.ShowItems();
            Console.WriteLine("Removing 'cent'");
            MyDictionary.RemoveElement("cent");
            MyDictionary.ShowItems();
            Console.WriteLine("------------------------");

        }
    }
}
