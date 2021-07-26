using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class Line
    {
        public int x1, x2, y1, y2;
        public Line(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;

        }

        public double Calculate()
        {
            return Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
        }
    }
}
