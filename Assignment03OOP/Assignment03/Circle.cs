using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    internal class Circle : ICircle
    {
        public double Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The Area Of The Circle = {Area}");
        }
    }
}
