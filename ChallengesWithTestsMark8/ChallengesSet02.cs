using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int x = 0;
           
            foreach (var item in vals)
            {
                x++;
                
            }
            if (x% 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
                        
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else
               return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            return Math.Min(length1, length2);
            
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
                return 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
                return 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    sum += numbers[i];
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;

            int sum = numbers.Sum();
            if (sum % 2 != 0)
                    return true;
            else
                return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
                return 0;
            else
                return number / 2;
        }
    }
}
