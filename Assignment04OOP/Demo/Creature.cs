using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal abstract class Creature
    {

        public abstract double Length { get; }
        public abstract void Move();
    }
}
