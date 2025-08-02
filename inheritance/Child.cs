using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.inheritance
{
    internal class Child : Parent 
    {
       public int z;
        public int Z { get; set; }
        public Child(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
       
    }
}
