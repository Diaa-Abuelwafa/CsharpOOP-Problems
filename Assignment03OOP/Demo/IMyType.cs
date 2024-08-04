using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal interface IMyType
    {
        public int ID { get; set; }
        // Not Automatic Property It Just Signature Of Property
        // No Generate Hidden Private Attribute [Backing Field]

        public void Display();
        // Signature Of Method

        public void Test(int X);
        // Signature Of Method

        public void Print()
        {
            Console.WriteLine("Hello World!");
        }
        // Default Implemented Method
    }
}
