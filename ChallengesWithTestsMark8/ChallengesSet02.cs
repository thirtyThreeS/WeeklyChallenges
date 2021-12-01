using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (char.IsLetter(c))
            {
                return true;
            }
            else if (char.IsDigit(c))
            {
                return false;
            }
            return false;   
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
                return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Any() == false)
            {
                return 0;
            }
                return numbers.Min() + numbers.Max();
            
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
                return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return 0;
            }
            else
            {
                foreach (int number in numbers)
                {
                    sum += number;
                }
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {

            if (numbers == null)
            {                                   //I couldnt figure this one out.. I spent hours on this... wanting to cry....
                                                       //then your answer was so simple :'( lol
                return false;
            }

            return (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {                                 //i couldnt figure this one out either but simple logic thinking outside the box
                                                    //i feel like i have a long path in front of me..
                return 0;
            }
            else
            {
                return number / 2;
            }




        }
    }
}
