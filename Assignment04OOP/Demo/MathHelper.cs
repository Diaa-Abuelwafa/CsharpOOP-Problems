using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class MathHelper
    {
        public static double PI { get; set; }

        // Static Constructor 
        static MathHelper()
        {
            PI = 3.14;
        }

        public static int Sumition(int A, int B)
        {
            return A + B;
        }

        public static double SQRT(int A)
        {
            return Math.Sqrt(A);
        }
    }
}
