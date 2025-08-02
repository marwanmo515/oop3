using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.inheritance
{
    internal class EBook : Book
    {
        #region attributes
        public string fileSize;
        #endregion 
               #region properties
        public string FileSize { get; set; }
        #endregion
        #region constructors
        public EBook(string title, string author, string isbn, string fileSize) : base(title, author, isbn)
        {
            FileSize = fileSize;
           
        }
        #endregion
        #region methods
        public override string ToString()
        {
            return $"{base.ToString()}, File Size: {FileSize}";
        }
        #endregion
    }
}
