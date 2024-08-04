using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class TypeD : TypeC
    {
        public int D { get; set; }

        public TypeD(int a, int b, int c, int d) : base(a, b, c)
        {
            this.D = d;
        }

        public new void Fun01()
        {
            Console.WriteLine("Hello At TypeD");
        }

        public override void Fun02()
        {
            Console.WriteLine($"A : {A}, B : {B}, C : {C}, D : {D}");
        }
    }
}
