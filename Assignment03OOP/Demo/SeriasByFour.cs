using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class SeriasByFour : ISerias
    {
        public int Current { get; set; }

        public void PlusCurrent()
        {
            Current += 4;
        }
    }
}
