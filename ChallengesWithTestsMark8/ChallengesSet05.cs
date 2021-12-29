using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var getHelp = startNumber + 1;
            //int getNext = 0;
            while (getHelp % n != 0)
            {
                getHelp++;
            }
           
            return getHelp;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue <= 0)
                {
                    businesses[i].Name = "CLOSED";      
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false;
            
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            int sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) return "";

            HashSet<string> result = new HashSet<string>();
            
            for (int i = 0; i < words.Length; i++)
            {
                result.Add(words[i]);
            }

            if (result.Count == 1) return "";
            
            return words.Aggregate((current, next) => current.Trim() + " " + next.Trim()).Trim() + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null) return new double[0];
            return elements.Where(x => x % 4 == 0).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            int tempSum = 0;
            if (nums == null || nums.Length == 0) return false;
            for (int n = 0; n < nums.Length; n++)
            {
                for (int u = n + 1; u < nums.Length; u++)
                {
                    tempSum = nums[n] + nums[u];
                    
                    if (tempSum == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
