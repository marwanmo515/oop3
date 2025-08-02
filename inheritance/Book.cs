using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.inheritance
{
    internal class Book
    {

        #region attributes
        public string title;
        public string author;
        public string isbn;
        #endregion


        #region properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        #endregion


        #region constructors
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
        }
        #endregion


    }
}
