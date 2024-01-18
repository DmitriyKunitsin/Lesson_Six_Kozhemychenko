using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    public class TByDiameter : TWheel
    {
        public double N { get; set; }
        public TByDiameter(double new_d, double new_n) : base(new_d)
        {
            N = new_n;
        }

        public override double Calculate()
        {
            return D + 2 * N;
        }

        public override string? ToString()
        {
            return $"По диаметру ({D}, {N})";
        }
    }
}
