using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12___Quick_Sort
{
    class Book : IComparable<Book>
    {
        private string ISBN;
        private string Title;
        private string Author;

        public Book(string ISBN, string Title, string Author)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
        }

        public override string ToString()
        {
            return ISBN + "\t" + Author + "\t" + Title;
        }

        public int CompareTo(Book other)
        {
            return (this.Title.CompareTo(other.Title));
            //return (this.ISBN.CompareTo(other.ISBN));
            //return (this.Author.CompareTo(other.Author));
        }
    }
}
