using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    abstract public class TWheel
    {
        public double D { get; set; }

        public TWheel(double new_d)
        {
            D = new_d;
        }

        abstract public double Calculate();
    }
}
