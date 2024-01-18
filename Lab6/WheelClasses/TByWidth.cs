using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    public class TByWidth : TWheel
    {
        public double N { get; set; }
        public double K { get; set; }
        public TByWidth(double new_d, double new_n, double new_k) : base(new_d)
        {
            N = new_n;
            K = new_k;
        }

        public override double Calculate()
        {
            return D + 2 * N * K;
        }

        public override string? ToString()
        {
            return $"По ширине ({D}, {N}, {K})";
        }
    }
}
