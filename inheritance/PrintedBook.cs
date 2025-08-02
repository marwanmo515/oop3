using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.inheritance
{
    internal class PrintedBook : Book
    {
        #region attributes
        public int pageCount;
        #endregion 
        #region properties
        public int PageCount { get; set; }
        #endregion
        #region constructors
        public PrintedBook(string title, string author, string isbn, int pageCount) : base(title, author, isbn)
        {
            PageCount = pageCount;
        }
        #endregion
        #region methods
        public override string ToString()
        {
            return $"{base.ToString()}, Page Count: {PageCount}";
        }
        #endregion
    }
}
