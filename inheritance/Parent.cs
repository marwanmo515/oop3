using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.inheritance
{
    internal class Parent
    {
        #region att
        public int x;
        public int y;
        #endregion

        #region prop
        public int X { get; set; }
        public int Y { get; set; }


        #endregion

        #region constructror
        public Parent(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion

        #region
        public int Product()
        {
            return x * y;
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return $"X = {x}, Y = {y}";
        }
        public void MyFun()
        {
            Console.WriteLine("Iam Parent");
        }
        #endregion
    }
}
