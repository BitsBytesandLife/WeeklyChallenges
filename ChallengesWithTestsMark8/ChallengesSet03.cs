using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var x in vals)
            {
                if (x == false)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (  numbers == null || !numbers.Any())
            {
                return false;
            }
            
            var numbersSum = numbers.Sum();

            return (numbersSum % 2 != 0) ? true : false;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");

            var isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasLowerChar.IsMatch(password);

            return isValidated;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
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
          
           

            return nums[nums.Length - 1] - nums[0];
   
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddBelow = new List<int>();

            for (int i = 1; i < 100; i++)
            {
                oddBelow.Add(i++);
            }

            return oddBelow.ToArray();
            
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            // words.Select(u => u.ToUpper());

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

            //foreach (var word in words)
            //{
            //    word.ToUpper();
            //}
            //words.Select(u => u.ToUpper());

            //List<string> newWords = new List<string>();
            //foreach (var item in words)
            //{
            //    item.ToUpper();
            //}



        }
    }
}
