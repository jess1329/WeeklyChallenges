using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetterOrDigit(c);
        }
            
             
        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length % 2 ==0)  
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
            return (number % 2 == 0) ? true : false;   
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null) || numbers.Count() ==0) 
            {
                return 0;   
            }
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else 
            {
                return str2.Length;
            }
        
        
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) 
            {
                return 0;
            }

            var sum = 0;

            for (var i = 0; i < numbers.Length; i++) 
            {
                sum += numbers{ i};
            }
            return sum;
        
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) 
            {
                return 0;
            }

            var evenSum = 0;

            foreach (var num in numbers) 
            {
                if (num % 2 == 0) 
                {
                    evenSum += num;
                }




            }

            return (numbers == null) ? 0 : numbers
                .Where(x => x % 2 == 0)
                .Sum();

        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) 
            {
                return false;
            }
             return (numbers.Sum() % 2 != 0);
                    
                    
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0) 
            {
                return 0;
            }

            return number / 2;



        }
    }
}
