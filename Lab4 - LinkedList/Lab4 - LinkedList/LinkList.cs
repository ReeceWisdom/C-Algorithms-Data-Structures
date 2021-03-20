using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4___LinkedList
{
    class LinkList
    {
        private Link list = null;
        public void AddItem(int item)
        {
            list = new Link(item, list);           
        }

        public string DisplayItems()
        {
            Link temp = list;
            string buffer = "";
            while (temp != null)
            {
                Console.WriteLine(temp.Data); //displays item
                temp = temp.Next; //next item
            }
            return buffer;
        }

        public int NumberOfItems()
        {
            Link temp = list;
            int count = 0;
            while (temp != null)
            {
                temp = temp.Next;
                count++;
            }
            return count;
        }
        
        public bool IsPresentItem(int item)
        {
            Link temp = list;
            while (temp != null)
            {
                if (temp.Data == item)
                {
                    Console.WriteLine("Searched Item = {0}", temp.Data);
                    return true;
                }
                else
                    temp = temp.Next;
            }
            Console.WriteLine("Searched Item Cannot be Found...");
            return false;
        }

        public void RemoveItem(int item)
        {
            Link temp = list;
            LinkList tempList = new LinkList();
            while (temp != null)
            {
                if (temp.Data != item)
                {
                    tempList.AddItem(temp.Data);
                }
                temp = temp.Next;
            }
            list = tempList.list;
        }

        public void InsertInOrder(int item)
        {
            bool added = false;
            Link temp = list;
            LinkList tempList = new LinkList();
            while(temp != null)
            {
                if ((temp.Data >= item) && (added == false))
                {
                    tempList.AddItem(item);
                    added = true;
                }
                tempList.AddItem(temp.Data);
                temp = temp.Next;
            }
            list = tempList.list;
        }
    }
}
