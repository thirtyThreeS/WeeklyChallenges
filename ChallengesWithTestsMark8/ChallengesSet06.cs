using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            //if string matches string you win, if not, gtfo
            //if (words == null && !words.Contains(word))
            //{
            //    return false;
            //}
            bool containsWord = false;

            foreach (string word2 in words)
            {
                if (word2 == null) return false;
                if (string.Equals(word, null) || words.Equals(null))
                {
                    return false;
                }
            }

            //if (words.Contains(null))
            //{
            //    return false;
            //}

            if (ignoreCase == true)
            {
                    word = word.ToLower();
                    //res = words.Any(x => x.ToLower() == word.ToLower());
                    List<string> list = words.Select(x => x.ToLower()).ToList();

                    containsWord = list.Contains(word);
            }

            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }

            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i < boundary; i += 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {

            //var dict = new Dictionary<char, int>();

            //for (int i = str.Length - 1; i > 0; i--)
            //{
            //    char c = str[i];

            //    if (char.IsLetter(c))
            //    {
            //        if (dict.ContainsKey(c))
            //        {
            //            dict[c]++;
            //        }
            //        else
            //        {
            //            dict.Add(c, 1);
            //        }
            //    }
            //}

            //var pair = dict.FirstOrDefault(x => x.Value == 1);

            //return ;





            int indexOf = -1;
            bool uniqueIndex;


            for (int i = 0; i < str.Length; i++)
            {
                uniqueIndex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if ((str[i] == str[j]) && i != j)
                    {
                        uniqueIndex = false;
                    }
                }

                if (uniqueIndex == true)
                {
                    return i;
                }
            }
            return indexOf;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i <= numbers.Length; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] != numbers[i])
                    {
                        break;
                    }
                    currentCount++;
                }
                
                if (currentCount > count)
                {
                    count = currentCount;
                }

            } return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
