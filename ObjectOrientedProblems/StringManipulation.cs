using System;
namespace ObjectOrientedProblems
{
	public class StringManipulation
	{
		public void ReverseWords(string s)
		{

            string[] wordsArray = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int i = 0;
            int j = wordsArray.Length - 1;
            while(i<=j)
            {
                string temp = wordsArray[i];
                wordsArray[i] = wordsArray[j];
                wordsArray[j] = temp;

                i++;
                j--;
            }

            foreach (string word in wordsArray)
            {
                Console.Write($"{word} ");
            }
            Console.WriteLine("\n");

        }
	}
}

