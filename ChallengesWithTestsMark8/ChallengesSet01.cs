using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            //throw new NotImplementedException();

            return Math.Min(minuend, subtrahend);   


        }

        public int Add(int number1, int number2)
        {
            //throw new NotImplementedException();

            return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            //throw new NotImplementedException();


            if (number1 < number2) 
            {
                return number1;
            }

            else 
            }

            return number2;

            }

        


        static void Main(string[] args)
        {
            smallest(100, 50, 25);
            smallest(50, 50, 25);
        }
    }













    public long Multiply(long factor1, long factor2)
        {
            throw new NotImplementedException();
        }

        public string GetGreeting(string nameOfPerson)
        {
            throw new NotImplementedException();
        }

        public string GetHey()
        {
            throw new NotImplementedException();
        }
    }
}
