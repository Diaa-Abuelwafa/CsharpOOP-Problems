﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Animal : Creature
    {
        public override void Move()
        {
            Console.WriteLine("Animal Is Moving ...");
        }
    }
}
