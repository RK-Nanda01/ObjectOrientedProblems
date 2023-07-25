using System;
namespace ObjectOrientedProblems
{
	public class Pattern
	{
		public void PrintPattern1()
		{
			for(int i = 8; i>=1; i--)
			{
				for(int j = i; j>=1; j--)
				{
					Console.Write("*");
				}
				Console.Write("\n");
			}
		}
        public void PrintPattern2()
        {
            for (int i = 7; i >= 1; i--)
            {
				if(i == 7 || i== 1)
				{
					Console.Write("*******");
				}

				else
				{
                    Console.Write("*     *");
                }

                Console.Write("\n");
            }
        }
    }
}

