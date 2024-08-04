using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal interface ISerias
    {
        public int Current { get; set; }

        public void PlusCurrent();
        public void Reset()
        {
            Current = 0;
        }
    }
}
