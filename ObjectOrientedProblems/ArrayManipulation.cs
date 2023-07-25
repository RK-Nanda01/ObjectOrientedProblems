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

        public Dictionary<int,int> GetFrequency(int[] arr)
        {
            Dictionary<int, int> dupCount = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (dupCount.ContainsKey(num))
                    dupCount[num]++;
                else
                    dupCount[num] = 1;
            }

            return dupCount;
        }
        public int DuplicateCount(int[] arr)
		{
            Dictionary<int, int> dupCount = new Dictionary<int, int>();
            dupCount = GetFrequency(arr);

            int totalDuplicates = 0;
            foreach (var pair in dupCount)
            {
                if (pair.Value > 1)
                    totalDuplicates++;
            }

            return totalDuplicates;
        }

        public List<int> UniqueElements(int[] arr)
        {
            Dictionary<int, int> dupCount = new Dictionary<int, int>();
            List<int> uniqueElements = new List<int>();

            dupCount = GetFrequency(arr);
            foreach (var pair in dupCount)
            {
                if (pair.Value == 1)
                    uniqueElements.Add(pair.Key);
            }

            return uniqueElements;
        }
        
    }
	
}

