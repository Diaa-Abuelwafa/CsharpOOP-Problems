using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class CompareInstructorById : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Instructor? I1 = (Instructor?)x;   // Un Safe Casting
            Instructor? I2 = (Instructor?)y;   // Un Safe Casting

            return I1?.ID.CompareTo(I2?.ID) ?? (I2 is null ? 0 : -1);
        }
    }
}
