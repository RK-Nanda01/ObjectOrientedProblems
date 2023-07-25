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

        public void MaxAndMin(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine($"Maximum Element is {max}");
            Console.WriteLine($"Minimum Element is {min}");
        }

        public int[] GetLowestNumbers(int[] arr)
        {
            int[] res = new int[3];
            res[0] = int.MaxValue; // Contains firstLowest
            res[1] = int.MaxValue; // Contains secondLowest
            res[2] = 0; // Contains sum of array
            foreach (int num in arr)
            {
                if (num < res[0])
                {
                    res[1] = res[0];
                    res[0] = num;
                }
                else if (num < res[1] && num != res[0])
                {
                    res[1] = num;
                }
                if(num >=0 )
                {
                    res[2] += num;
                }
            }



            return res;
        }

    }
	
}

