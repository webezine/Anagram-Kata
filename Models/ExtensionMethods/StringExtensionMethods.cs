using System;
using System.Linq;

namespace AnagramConsole.Models.ExtensionMethods
{
    public static class StringExtensionMethods
    {
        public static string ReverseString(this string s)
        {
            // Convert to char array, then reverse the array...
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public static bool IsAnAnagram(this string s1, string s2)
        {
            // Strip all white space from string to allow for multiple word anagrams - not just one word.
            var wordOne = string.Concat(s1.Where(c => !Char.IsWhiteSpace(c)));
            var wordTwo = string.Concat(s2.Where(c => !Char.IsWhiteSpace(c)));

            // Scenario 1 : Empty strings - not an anagram...
            if (string.IsNullOrEmpty(wordOne) || string.IsNullOrEmpty(wordTwo))
            {
                return false;
            }
            
            // Scenario 2: string lengths don't match - not an anagram...
            if (wordOne.Length != wordTwo.Length)
            {
                return false;
            }

            var wordOneLower = wordOne.ToLower();
            var wordTwoLower = wordTwo.ToLower();

            // Scenario 3: string is the same forwards & backwards - is an anagram (a Palindrome)...
            if (wordOneLower == wordTwoLower.ReverseString() )
            {
                return true;
            }

            // Scenario 4: string is NOT the same forwards & backwards - is NOT an anagram.
            if (wordOneLower == wordTwoLower && wordOneLower != wordTwoLower.ReverseString())
            {
                return false;
            }

            // Scenario 5: Length matches, not null & we have established they are not the same words backwards & forwards -
            // check by char - sort into char arrays and order. Comparsion check.
            var wordOneArray = wordOneLower.ToCharArray();
            var wordTwoArray = wordTwoLower.ToCharArray();

            Array.Sort(wordOneArray);
            Array.Sort(wordTwoArray);

            var arrayToStringOne = new string(wordOneArray);
            var arrayToStringTwo = new string(wordTwoArray);

            return arrayToStringOne == arrayToStringTwo;
        }

    }
}
