using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
          
            return numbers.Where(n => n % 2 == 0).Sum() + numbers.Where(n => n % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string[] strings = { str1, str2, str3, str4 };
            return strings.Where(s => !string.IsNullOrEmpty(s)).Min(s => s.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(Math.Min(number1, number2), number3), number4);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            int[] sides = { sideLength1, sideLength2, sideLength3 };
            Array.Sort(sides);
            return sides[0] + sides[1] > sides[2];
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int countNull = objs.Count(obj => obj == null);
            int countNonNull = objs.Length - countNull;

            return countNull > countNonNull;
        }

        public double AverageEvens(int[] numbers)
        {
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            return evenNumbers.Any() ? evenNumbers.Average() : 0;
        }

        public int Factorial(int number)
        {
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
