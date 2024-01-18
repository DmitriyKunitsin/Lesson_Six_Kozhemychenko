using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    public class TByRim : TWheel
    {
        public double N { get; set; }
        public TByRim(double new_d, double new_n) : base(new_d)
        {
            N = new_n;
        }

        public override double Calculate()
        {
            return (1 + N) * D;
        }

        public override string? ToString()
        {
            return $"По диску ({D}, {N})";
        }
    }
}
