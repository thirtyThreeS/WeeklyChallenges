using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var oddd = numbers.Where(x => x % 2 != 0).Sum();
            var even = numbers.Where(x => x % 2 == 0).Sum();

            return even - oddd;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strings = new string[4] { str1, str2, str3, str4 };
            
            var shortestString = strings.OrderBy(x => x.Length).FirstOrDefault();

            return shortestString.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] number = new int[4] { number1, number2, number3, number4 };

            return number.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 == 0 || sideLength2 == 0 || sideLength3 == 0) return false;
            
            int[] triangle = new int[3] { sideLength1, sideLength2, sideLength3 };

            return triangle.All(x => sideLength1 + sideLength2 > sideLength3 && 
                                     sideLength1 + sideLength3 > sideLength2 && 
                                     sideLength2 + sideLength3 > sideLength1);  
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double number);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int isNull = 0;
            int noNull = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    isNull++;
                }
                else if (objs[i] != null)
                {
                    noNull++;
                }
            }
            return isNull > noNull;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            int isEven = 0;

            foreach(int number in numbers)
            {
                if (number % 2 == 0)
                {
                    isEven++;
                }

            }

            if (isEven == 0) return 0;

            return numbers.Where(x => x % 2 == 0).Average();
        }

        public int Factorial(int number)
        {
            if (number == 0) return 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            int fact = 1;
            while (number != 1)
            {
                fact = fact * number;
                number = number - 1;
            }
            return fact;

            //if (number == 1) return 1;
            //return number * Factorial(number - 1);
        }
    }
}
