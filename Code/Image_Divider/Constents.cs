using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emgu.CV.Structure;

namespace Data
{
    class Constents
    {
        public int ROWS_MIN = 50;
        public int COLS_MIN = 50;
        public MCvScalar Line_Color = new MCvScalar(0, 0, 255);
        public int Line_Thickness_Small = 1;
        public int Line_Thickness_Medium = 4;
        public int Line_Thickness_Large = 12;
        public int Line_Thickness_Huge = 16;
        public int Line_Thickness_Ultra = 25;
    }
}
