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

        public string CapitalizeFirstLetter(string s)
        {
            string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = CapitalizeWord(words[i]);
            }

            return string.Join(" ", words);
        }

        public string CapitalizeWord(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return string.Empty;
            }

            char[] charArray = word.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);
            return new string(charArray);
        }
    }
}

