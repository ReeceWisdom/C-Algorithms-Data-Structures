using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5___LinkedListGen
{
    class LinkListGen<T> where T : IComparable
    {
        private LinkGen<T> list = null;

        public void AddItem(T item)
        {
            list = new LinkGen<T>(item, list);
        }

        public string DisplayItems()
        {
            LinkGen<T> temp = list;
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
            LinkGen<T> temp = list;
            int count = 0;
            while (temp != null)
            {
                temp = temp.Next;
                count++;
            }
            return count;
        }

        public bool IsPresentItem(T item)
        {
            LinkGen<T> temp = list;
            while (temp != null)
            {
                if (temp.Data.Equals(item))
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

        public void RemoveItem(T item)
        {
            LinkGen<T> temp = list;
            LinkListGen<T> tempList = new LinkListGen<T>();
            while (temp != null)
            {
                if (item.CompareTo(temp.Data) != 0)
                {
                    tempList.AddItem(temp.Data);
                }
                temp = temp.Next;
            }
            list = tempList.list;
        }

        public void AppendItem(T item)
        {
            LinkGen<T> temp = list;

            if (temp == null)
                list = new LinkGen<T>(item);
            else
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new LinkGen<T>(item);
            }
        }

        /*public void InsertInOrder(T item)
        {
            bool added = false;
            LinkGen<T> temp = list;
            LinkListGen<T> tempList = new LinkListGen<T>();
            while (temp != null)
            {
                if ((temp.Data.CompareTo(item) >= 0) && (added == false))
                {
                    tempList.AddItem(item);
                    added = true;
                }
                tempList.AddItem(temp.Data);
                temp = temp.Next;
            }
            list = tempList.list;
        }*/

        public void InsertInOrder(T item)
        {
            LinkGen<T> temp = list;
            LinkListGen<T> tempList = new LinkListGen<T>();
            while ((temp != null) && (temp.Data.CompareTo(item) < 0))
            {
                tempList.AppendItem(temp.Data);
                temp = temp.Next;
            }
            tempList.AppendItem(item);

            while (temp != null)
            {
                tempList.AppendItem(temp.Data);
                temp = temp.Next;
            }
            list = tempList.list;
        }

        public void Concat(LinkListGen<T> tempList2)
        {
            LinkGen<T> temp = list;
            
            while (temp != null)
            {
                tempList2.AppendItem(temp.Data);
                temp = temp.Next;
            }
            list = tempList2.list;
        }

        public void Copy(LinkListGen<T> tempList)
        {
            LinkGen<T> temp = list;
            while (temp != null)
            {
                tempList.AddItem(temp.Data);
                temp = temp.Next;
            }
            list = tempList.list;
        }

        public void Sort()
        {
            LinkGen<T> temp = list;
            LinkListGen<T> tempList = new LinkListGen<T>();
            while (temp != null)
            {
                tempList.InsertInOrder(temp.Data);
                temp = temp.Next;
            }
            list = tempList.list;
        }
    }
}
