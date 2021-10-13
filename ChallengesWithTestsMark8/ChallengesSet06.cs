using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }

            switch (ignoreCase)
            {
                case true:
                    foreach (var thing in words)
                    {
                        if (thing == null)
                        {
                            continue;
                        }
                        if (thing.ToLower() == word.ToLower())
                        {
                            return true;
                        }
                    }
                    return false;
                case false:
                    foreach (var thing in words)
                    {
                        if (thing == word)
                        {
                            return true;
                        }
                    }
                    return false;
                default:
                    Console.WriteLine("What did you do? You weren't supposed to do that!");
                    break;
            }
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2)
            {
                return false;
            }


            for (int i = 2; i <= num / 2; i++)
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
            int[] uniques = new int[str.Length];
            int index = -1;

            for (int i = 0; i < uniques.Length; i++)
            {
                uniques[i] = i;
            }

            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int y = i + 1; y < str.Length; y++)
                {
                    if(str[i] == str[y])
                    {
                        uniques[i] = str.Length + 1;
                        uniques[y] = str.Length + 1;
                    }
                }
            }

            foreach (var num in uniques)
            {
                if (num != str.Length + 1)
                {
                    index = num;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 1;
            int finalCount = 1;
            int temp = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (temp == numbers[i])
                {
                    count++;
                    if (count > finalCount)
                    {
                        finalCount = count;
                    }
                }
                else
                {
                    count = 1;
                    temp = numbers[i];
                }
            }
            return finalCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> temp = new List<double>();
            if (elements == null || n < 1)
            {
                return temp.ToArray();
            }

            for (int i = n-1; i < elements.Count; i += n)
            {
                temp.Add(elements[i]);
            }
            return temp.ToArray();
        }
    }
}
