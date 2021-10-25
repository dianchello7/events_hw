using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class BaseShape
    {
        protected BaseShape(Point leftTop, char theChar)
        {
            LeftTop = leftTop;
            TheChar = theChar;
        }

        public Point LeftTop { get; set; }
        public char TheChar { get; set; }

        public abstract void PrintShape();



    }

}


