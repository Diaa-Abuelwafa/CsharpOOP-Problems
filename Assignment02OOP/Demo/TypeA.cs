using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class TypeA
    {
        public int A { get; set; }

        public TypeA(int a)
        {
            this.A = a;
        }

        public void Fun01()
        {
            Console.WriteLine("Hello At TypeA");
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"A : {A}");
        }
    }
}
