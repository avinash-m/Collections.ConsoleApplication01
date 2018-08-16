using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ConsoleApplication01
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Adding items to ArrayList by calling Add method");
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

        }
    }
}
