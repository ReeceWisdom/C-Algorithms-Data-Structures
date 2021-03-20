using System;

namespace Lab4___LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList testList = new LinkList();
            Random randgen = new Random();

            for (int i = 1; i < 8; i++)
                testList.AddItem(i);
                //testList.AddItem(randgen.Next(20));

            testList.DisplayItems();

            Console.WriteLine("\nNo. of Items = {0}\n", testList.NumberOfItems());
            Console.WriteLine("Is 17 Present? --- {0}\n", testList.IsPresentItem(17));
            Console.WriteLine("Is 3 Present? --- {0}\n", testList.IsPresentItem(3));

            testList.RemoveItem(3);
            testList.InsertInOrder(12);
            testList.DisplayItems();

            Console.WriteLine("\nNo. of Items = {0}\n", testList.NumberOfItems());

            Console.ReadKey();
        }
    }
}
