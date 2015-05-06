using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Solutions.Problem9
{
    public class BruteForce
    {
        public static int Solve(int sum)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            for (a = 0; a < sum; a++)
            {
                for (b = 0; b < sum; b++)
                {
                    for (c = 0; c < sum; c++)
                    {
                        if(a + b + c == sum && PythagoreanTriplet.Validate(a, b, c))
                        {
                            return a * b * c;
                        }
                    }
                }
            }

            return 0;
        }
    }
}
