using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    internal class _3DPoint : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public _3DPoint(int x, int y, int z) : this(x, y)
        {
            this.Z = z;
        }

        public _3DPoint(int x, int y) : this(x)
        {
            this.Y = y;
        }

        public _3DPoint(int x) : this()
        {
            this.X = x;
        }

        public _3DPoint()
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
        }

        public override string ToString()
        {
            return $"Point Coordinates : ({X}, {Y}, {Z})";
        }

        public int CompareTo(object? obj)
        {
            _3DPoint P = (_3DPoint) obj;

            if(this.X > P.X && this.Y > P.Y)
            {
                return 1;
            }
            else if (this.X < P.X && this.Y < P.Y)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public object Clone()
        {
            // Deep Copy

            _3DPoint P = new _3DPoint();

            P.X = this.X;
            P.Y = this.Y;
            P.Z = this.Z;

            return P;
        }

        public static bool operator==(_3DPoint P1, _3DPoint P2)
        {
            if(P1.X == P2.X && P1.Y == P2.Y && P1.Z == P2.Z)
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(_3DPoint P1, _3DPoint P2)
        {
            if (P1.X != P2.X && P1.Y != P2.Y && P1.Z != P2.Z)
            {
                return true;
            }

            return false;
        }
    }
}
