using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0) ? true : false;
            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return(num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Any() == false)
            {
                return 0;
            }

            var min = numbers.Min();
            var max = numbers.Max();

            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {

            int str1L = str1.Length;
            int str2L = str2.Length;

            if (str1L == str2L)
            {
                return str1L;
            }
            else if (str1L < str2L)
            {
                return str1L;
            }
            else if (str1L > str2L)
            {
               return str2L;
            }
            else
            {
                return 0;
            }
        }

        public int Sum(int[] numbers)
        {
            var total = 0;
            
            if (numbers == null)
            {
                return 0;
            }
            
            foreach (var item in numbers)
            {
                total += item;
            }

            return total;
        }

        public int SumEvens(int[] numbers)
        {
            var total = 0;

            if (numbers == null)
            {
                return 0;
            }

            foreach (var item in numbers)
            {
                if (item % 2 == 0) 
                {
                    total += item;
                }
            }

            return total;

            
        }

        public bool IsSumOdd(List<int> numbers)
        {

            if (numbers != null)
            {

                return (numbers.Sum() % 2 != 0) ? true : false;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {


            if (number < 0)
            {
                return 0;
            }
            
            return number / 2;
            //if (number >= -1 || number == 0)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return number / 2;
            //}
            

            //throw new NotImplementedException();
        }
    }
}
