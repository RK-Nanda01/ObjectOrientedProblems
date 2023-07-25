using System;
namespace ObjectOrientedProblems
{
	public class DigitManipulation
	{
		public int SumOfDigits(int n)
		{
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum+= digit;
                n = n / 10;
            }
            return sum;
        }
	}
}

