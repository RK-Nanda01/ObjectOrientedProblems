using System;
namespace ObjectOrientedProblems
{
    public class ArrayManipulation
    {
        public int [] initialiseArray(int n)
        {
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array");
            for(int i = 0;i<n; i++)
            {
               arr[i]=Convert.ToInt32(Console.ReadLine());
            }


            return arr;
        }
		public int DuplicateCount(int[] arr)
		{
            Dictionary<int, int> dupCount = new Dictionary<int, int>();

           
            foreach (int num in arr)
            {
                if (dupCount.ContainsKey(num))
                    dupCount[num]++;
                else
                   dupCount[num] = 1;
            }

            
            int totalDuplicates = 0;
            foreach (var pair in dupCount)
            {
                if (pair.Value > 1)
                    totalDuplicates++;
            }

            return totalDuplicates;
        }
    }
	
}

