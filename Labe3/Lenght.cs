﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labe3
{
    public class Lenght
    {
        private double value;
        private string type;
        public Lenght(double value, string type)
        {
            this.value = value;
            this.type = type;
        }
        public string Verbose()
        {
            return String.Format("{0} {1}", this.value, this.type);
        }
    }
}
