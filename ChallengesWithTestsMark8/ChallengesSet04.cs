using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {

            var evenNums = 0;
            var oddNums = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNums += numbers[i];
                }
                else
                {
                    oddNums += numbers[i];
                }
            }

            return evenNums - oddNums;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> stringLen = new List<int>();
            var str1Len = str1.Length;
            stringLen.Add(str1Len);

            var str2Len = str2.Length;
            stringLen.Add(str2Len);

            var str3Len = str3.Length;
            stringLen.Add(str3Len);

            var str4Len = str4.Length;
            stringLen.Add(str4Len);

            return stringLen.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numList = new List<int>();
            numList.Add(number1);
            numList.Add(number2);
            numList.Add(number3);
            numList.Add(number4);

            return numList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            Business myBiz = new Business();
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if ( (sideLength1 + sideLength2 > sideLength3) && (sideLength2 + sideLength3 > sideLength1) && (sideLength1 + sideLength3 > sideLength2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            
            if (input is null || input == "")
            {
                return false;
            }

            bool isNum = double.TryParse(input,out double x);


            return isNum; ;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullCount = 0;
            var objsLen = objs.Length;
            foreach (var item in objs)
            {
                if (item == null)
                {
                    nullCount++;
                }
            }
          
            return (nullCount > objsLen / 2) ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
            double total = 0;
            var count = 0;
           
            if (numbers == null)
            {
                return 0;
            }
            
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    total += numbers[i];
                    count++;
                }
            }

            if (count == 0)
            {
                return 0;
            }
            
            return total / count;
        }

        public int Factorial(int number)
        {

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number == 0)
            {
                return 1;
            }

            int result = 1;
                      
            while(number != 1)
            {
                    result = result * number;
                    number = number - 1;
            }
            return result;
           
        }
    }
}
