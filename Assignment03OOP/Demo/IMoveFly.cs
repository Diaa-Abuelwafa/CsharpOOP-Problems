using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal interface IMoveFly
    {
        public int Speed { get; set; }

        public void Forward();
        public void Backward();
        public void Left();
        public void Right();
    }
}
