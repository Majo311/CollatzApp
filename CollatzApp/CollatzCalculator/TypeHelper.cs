using System;
using System.Collections.Generic;

namespace CollatzCalculator
{
    public static class TypeHelper
    {
        public static IEnumerable<uint> GetDigits(this string txtValue)
        {
            uint result;
            foreach (char digit in txtValue)
            {
                if (!uint.TryParse(digit.ToString(), out result))
                {
                    throw new Exception("Incorrect parameter txtValue, the Input is incorrect!");
                }
                yield return result;
            }
        }
    }
}
