using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToIntConversionDev
{
    public class RomanToInt
    {
        public int Convert(string input)
        {
            return 0;
        }

        private static Dictionary<char, int> RomanIntMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };


        public static int RomanToInteger(string roman)
        {
            int number = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && RomanIntMap[roman[i]] < RomanIntMap[roman[i + 1]])
                {
                    number -= RomanIntMap[roman[i]];
                }
                else
                {
                    number += RomanIntMap[roman[i]];
                }
            }
            return number;
        }


    }
}
