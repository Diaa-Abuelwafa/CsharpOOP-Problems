using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : IMyType
    {
        public int ID { get; set; }

        public void Display()
        {
            Console.WriteLine("Hello Function Display");
        }

        public void Test(int Num)
        {
            Console.WriteLine($"X = {Num}");
        }
    }
}
