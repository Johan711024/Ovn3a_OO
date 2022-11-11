﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn3a_OO
{
    public class Flamingo : Bird
    {
        public Flamingo(string name, int weight, int age) : base(name, weight, age)
        {
        }

        public int NumInHerd { get; set; }
    }
}
