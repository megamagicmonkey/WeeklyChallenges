using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool value in vals)
            {
                if (value == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            
            if (numbers == null)
            {
                return false;
            }
            foreach (int num in numbers)
            {
                sum += num;
            }
            if (sum % 2 == 0)
            {
                return false;
            }
            else return true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool number = false;
            var checker = password.ToCharArray();
            if (password == null)
            {
                return false;
            }
            foreach (char character in checker)
            {
                if (char.IsUpper(character))
                {
                    upper = true;
                }
                if (char.IsLower(character))
                {
                    lower = true;
                }
                if (char.IsNumber(character))
                {
                    number = true;
                }
            }
            if (upper && lower && number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            var charArray = val.ToCharArray();
            return charArray[0];
        }

        public char GetLastLetterOfString(string val)
        {
            //var charArray = val.ToCharArray();
            //int length = charArray.Length;
            //return charArray[length - 1];

            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            int length = nums.Length;
            return nums[length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> holder = new List<int>();
            for (int i = 1; i < 100; i += 2)
            {
                holder.Add(i);
            }
            var result = holder.ToArray();
            return result;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
            
        }
    }
}
