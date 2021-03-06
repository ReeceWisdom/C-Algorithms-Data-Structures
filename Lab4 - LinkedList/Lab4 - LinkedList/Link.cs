using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4___LinkedList
{
    class Link
    {
        private int data;
        private Link next;

        public Link(int item) 
        {
            data = item;
            next = null;
        }

        public Link(int item, Link list)
        {
            data = item;
            next = list;
        }

        public int Data
        {
            set { this.data = value; }
            get { return this.data; }
        }

        public Link Next
        {
            set { this.next = value; }
            get { return this.next; }
        }
    }
}
