using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Utils
{
    public class Factorial
    {
        public static int Generate(int value)
        {
            int result = 1;
            int currentValue = value;

            while (currentValue > 0)
            {
                result *= currentValue;
                currentValue--;
            }

            return result;
        }

        public static BigInteger Generate(BigInteger value)
        {
            BigInteger result = new BigInteger(1);

            BigInteger currentValue = value;

            while(currentValue > 0)
            {
                result *= currentValue;
                currentValue--;
            }

            return result;
        }
    }
}
