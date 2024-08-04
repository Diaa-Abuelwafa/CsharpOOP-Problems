using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }

        public new void Fun01()
        {
            Console.WriteLine("Hello At TypeB");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A : {A}, B : {B}");
        }
    }
}
