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
                if(result==0)
                {
                    throw new Exception("Incorrect parameter txtValue, the Input is incorrect! Right values are >0");
                }
                yield return result;
            }
        }
        public static string AsString(this IEnumerable<string> SequenceValues)
        {
            string result = string.Empty;
           foreach(string item in SequenceValues)
           {
                result += item + ";";
           }
            return result;
        }
    }
}
