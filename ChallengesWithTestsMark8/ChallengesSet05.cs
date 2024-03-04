using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int nextNumber = startNumber + (n - startNumber % n) % n;
            return nextNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses.Where(b => b.Revenue == 0))
            {
                business.Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            return numbers.Zip(numbers.Skip(1), (a, b) => a <= b).All(result => result);
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            for (int i = 1; i < numbers.Length; i += 2)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            return string.Join(" ", words.Where(w => !string.IsNullOrWhiteSpace(w))) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            return elements.Where((element, index) => (index + 1) % 4 == 0).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            return nums.SelectMany((num, index) => nums.Skip(index + 1).Select(other => num + other)).Any(sum => sum == targetNumber); ;
        }
    }
}
