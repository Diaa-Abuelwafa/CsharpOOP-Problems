using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class TypeC : TypeB
    {
        public int C { get; set; }

        public TypeC(int a, int b, int c) : base(a, b)
        {
            C = c;
        }

        public new void Fun01()
        {
            Console.WriteLine("Hello At TypeC");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A : {A}, B : {B}, C : {C}");
        }
    }
}
