using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }

            var sum = numbers.Sum();

            return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            bool result =
                            password.Any(c => char.IsLower(c)) &&
                            password.Any(c => char.IsUpper(c)) &&
                            password.Any(c => char.IsDigit(c));
                            //password.Any(c => char.IsSymbol(c));
            return result;
            
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return (val[val.Length - 1]);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }
            
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return (nums.Last() - nums.First());
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddsBelowOneHundred = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    oddsBelowOneHundred.Add(i);
                }
            }
            return oddsBelowOneHundred.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
                
            }

            
        }
    }
}
