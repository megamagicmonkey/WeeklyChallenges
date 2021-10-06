using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int iteration = startNumber;
            do
            {
                iteration++;
                if (iteration % n == 0)
                {
                    return iteration;
                }
            } while (true);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach(var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            if (numbers.Length == 1)
            {
                return true;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int total = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return total;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    total += numbers[i];
                }
            }
            return total;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
            if (words == null)
            {
                return "";
            }
            foreach (var word in words)
            {
                sentence += $" {word.Trim()}";
                sentence = sentence.Trim();
            }
            if (sentence != "")
            {
                sentence += ".";
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> temp = new List<double>();
            if (elements == null)
            {
                return temp.ToArray();
            }
            for (int i = 3; i < elements.Count; i += 4){
                temp.Add(elements[i]);
            }
            return temp.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 1)
            {
                return false;
            }
            for (int i = nums.Length -1; i >= 1; i--)
            {
                for (int y = i - 1; y >= 0; y--)
                {
                    if (nums[i] + nums[y] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
