using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Point
    {
        public int X;
        public int Y;

        public Point()
        {
            // Work --> auto-default
        }

        public Point(int _x, int _y)
        {
            this.X = _x;
            this.Y = _y;
        }

        public override string ToString()
        {
            return $"X = {X} : Y = {Y}";
        }
    }
}
