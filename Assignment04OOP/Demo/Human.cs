using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Human : Creature
    {
        public override double Length { get; }
        public override void Move()
        {
            Console.WriteLine("Human Is Moving ...");
        }
    }
}
