using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    result += num;
                }
                else
                {
                    result -= num;
                }
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int length = str1.Length;
            string[] strArray = { str1, str2, str3, str4 };
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length < length)
                {
                    length = strArray[i].Length;
                }
            }
            return length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = number1;
            int[] intArray = { number1, number2, number3, number4 };

            foreach(int num in intArray)
            {
                if (smallest > num)
                {
                    smallest = num;
                }
            }
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            /*
             Why doesn't this work?
             * 
             int[] intArray = { sideLength1, sideLength2, sideLength3 };

            intArray.OrderBy(x => x);

            int sum = intArray[0] + intArray[1];

            return (sum > intArray[2]);
            */

            var list = new List<int> { sideLength1, sideLength2, sideLength3 }.OrderBy(x => x).ToList();

            int sum = list[0] + list[1];
            return (sum > list[2]);

        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double output);
  
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nulled = 0;
            int nonNull = 0;
            foreach (var unit in objs)
            {
                if (unit == null)
                {
                    nulled++;
                }
                else
                {
                    nonNull++;
                }
            }
            if (nulled > nonNull)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            double total = 0;
            double iterations = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    total += num;
                    iterations++;
                }
            }
            if (iterations == 0)
            {
                return 0;
            }

            double result = total / iterations;
            return result;
        }

        public int Factorial(int number)
        {
            int total = 1;
            if (number == 0)
            {
                return total;
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = 1; i <= number; i++)
            {
                total = total * i;
            }
            return total;
        }
    }
}
