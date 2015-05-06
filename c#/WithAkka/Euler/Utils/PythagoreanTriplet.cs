using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class PythagoreanTriplet
    {
        public static bool Validate(int a, int b, int c)
        {
            if(a < b && b < c)
            {
                if((a*a) + (b*b) == (c*c))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool Validate(Triplet triplet)
        {
            return Validate(triplet.A, triplet.B, triplet.C);
        }
    }
}
