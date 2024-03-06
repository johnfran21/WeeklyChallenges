using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            throw new NotImplementedException();
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }

            int sqrt = (int)Math.Sqrt(num);
            for (int i = 2; i <= sqrt; i++)
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
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {

            throw new NotImplementedException();
            //int maxConsecutiveCount = 0;
            //int currentConsecutiveCount = 0;

            //for (int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] == numbers[i - 1] + 1)
            //    {
            //        currentConsecutiveCount++;
            //    }
            //    else
            //    {
            //        maxConsecutiveCount = Math.Max(maxConsecutiveCount, currentConsecutiveCount);
            //        currentConsecutiveCount = 0;
            //    }
            //}
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            return elements.Where((element, index) => (index + 1) % n == 0).ToArray();
        }
    }
}
