using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler.Utils
{
    public class SumOfDigits
    {
        public static int Generate(int value)
        {
            int result = 0;
            int currentValue = value;

            while (currentValue > 0)
            {
                int digit = currentValue % 10;
                result += digit;

                currentValue /= 10;
            }

            return result;
        }

        public static int GenerateForEachCharInString(int value)
        {
            int result = 0;
            string valueString = value.ToString();

            foreach (var item in valueString)
            {
                result += int.Parse(item.ToString());
            }


            return result;
        }

        public static int GenerateForCharInString(int value)
        {
            int result = 0;
            string valueString = value.ToString();

            for (int i = 0; i < valueString.Length; i++)
            {
                char item = valueString[i];
                result += int.Parse(item.ToString());
            }

            return result;
        }


        public static BigInteger Generate(BigInteger value)
        {
            BigInteger result = 0;
            BigInteger currentValue = value;

            while (currentValue > 0)
            {
                BigInteger digit;
                BigInteger.DivRem(currentValue, 10, out digit);
                //int digit = currentValue % 10;
                result += digit;

                currentValue /= 10;
            }

            return result;
        }
    }
}
