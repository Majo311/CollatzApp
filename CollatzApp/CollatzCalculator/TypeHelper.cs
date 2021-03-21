using System;
using System.Collections.Generic;
using System.Linq;

namespace CollatzCalculator
{
    public static class TypeHelper
    {
        /// <summary>
        /// Method GetDigits() returns numeric digits as IEnumerable
        /// </summary>
        /// <param name="txtValue"></param>
        /// <returns></returns>
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
        /// <summary>
        /// AsString method return sequences as one string
        /// </summary>
        /// <param name="SequenceValues"></param>
        /// <returns></returns>
        public static string AsString(this IEnumerable<string> SequenceValues)
        {
            string result = string.Empty;
           foreach(string item in SequenceValues)
           {
                result += item + ";";
           }
            return result;
        }

        /// <summary>
        /// Method IsInputZero is checking if all input characters aren't zero
        /// </summary>
        /// <param name="SequenceValues"></param>
        /// <returns></returns>
        public static bool IsInputZero(this IEnumerable<uint> SequenceValues)
        {
            List<uint> zeroValues=  SequenceValues.Where(item => item==0).ToList();
            return zeroValues.Count == SequenceValues.ToList().Count ? true : false;
        }
    }
}
