using System;
using System.Collections.Generic;
using System.Text;

namespace C18_Ex02
{
    public struct Coordinates
    {
        private int row;
        private int column;
        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        public int Column
        {
            get { return column; }
            set { column = value; }
        }

    }
}
