using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Triplet
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override string ToString()
        {
            return String.Format("A: {0}, B: {1}, C: {2}", A, B, C);
        }
    }
}
