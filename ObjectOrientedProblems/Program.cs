using System.Runtime.Intrinsics.Arm;

namespace ObjectOrientedProblems;
class Program
{
    static void Main(string[] args)
    {
        bool flag = true;
        int option;
        Console.WriteLine("Welcome to Object Oriented Problems");
        while (flag)
        {
            Console.WriteLine("MENU:->");
            Console.WriteLine("1. Find total Duplicates in an array");
            Console.WriteLine("2. Print Unique Elements of array");
            Console.WriteLine("3. Print Frequency of Elements of array");
            Console.WriteLine("4. Find Maximum and Minimum Element in array");
            Console.WriteLine("5. Print Pattern 1");
            Console.WriteLine("6. Print Pattern 2");
            Console.WriteLine("7. Reverse Word");
            Console.WriteLine("8. Sum of Digits");
            Console.WriteLine("9. Convert First Letter to Capital");
            Console.WriteLine("10. Find 2 Lowest Number and print sum");
            Console.WriteLine("0. Exit");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 0:
                    {
                        flag = false;
                        break;
                    }
                case 1:
                    {
                        int n;
                        Console.WriteLine("Enter the size of the array");
                        n = Convert.ToInt32(Console.ReadLine());
                        ArrayManipulation a = new ArrayManipulation();
                        int[] arr = a.initialiseArray(n);
                        int dup = a.DuplicateCount(arr);
                        Console.WriteLine($"Count of Duplicate Elements is {dup}");
                        break;
                    }
                case 2:
                    {
                        int n;
                        Console.WriteLine("Enter the size of the array");
                        n = Convert.ToInt32(Console.ReadLine());
                        ArrayManipulation a = new ArrayManipulation();
                        int[] arr = a.initialiseArray(n);
                        List<int> uniqueElements = new List<int>();
                        uniqueElements = a.UniqueElements(arr);
                        Console.WriteLine($"Unique Elements are:->");
                        foreach (int u in uniqueElements)
                        {
                            Console.Write($"{u} ");
                        }
                        Console.Write("\n");
                        break;
                    }
                case 3:
                    {
                        int n;
                        Console.WriteLine("Enter the size of the array");
                        n = Convert.ToInt32(Console.ReadLine());
                        ArrayManipulation a = new ArrayManipulation();
                        int[] arr = a.initialiseArray(n);
                        Dictionary<int, int> freq = new Dictionary<int, int>();
                        freq = a.GetFrequency(arr);

                        foreach(var ele in freq)
                        {
                            Console.WriteLine($"Frequency of {ele.Key} is {ele.Value}");
                        }
                        break;
                    }
                case 4:
                    {
                        int n;
                        Console.WriteLine("Enter the size of the array");
                        n = Convert.ToInt32(Console.ReadLine());
                        ArrayManipulation a = new ArrayManipulation();
                        int[] arr = a.initialiseArray(n);

                        a.MaxAndMin(arr);
                        
                        break;
                    }
                case 5:
                    {
                       
                        Pattern p = new Pattern();
                        p.PrintPattern1();
                        break;
                    }
                case 6:
                    {

                        Pattern p = new Pattern();
                        p.PrintPattern2();
                        break;
                    }
                case 7:
                    {
                        string s;
                        Console.WriteLine("Enter string");
                        s = Console.ReadLine();
                        StringManipulation str = new StringManipulation();
                        str.ReverseWords(s);
                        break;
                    }
                case 8:
                    {
                        int n;
                        Console.WriteLine("Enter Number");
                        n = Convert.ToInt32(Console.ReadLine());
                        DigitManipulation dm = new DigitManipulation();
                        Console.WriteLine($"Sum of Digits is {dm.SumOfDigits(n)}"); 
                        break;
                    }
                case 9:
                    {
                        string str;
                        string res;
                        Console.WriteLine("Enter string");
                        str= Console.ReadLine();
                        StringManipulation s = new StringManipulation();
                        res = s.CapitalizeFirstLetter(str);
                        Console.WriteLine($"Before Capitalization--> {str}");
                        Console.WriteLine($"After Capitalization--> {res}");
                        break;
                    }
                case 10:
                    {
                        int n;
                        Console.WriteLine("Enter the size of the array");
                        n = Convert.ToInt32(Console.ReadLine());
                        ArrayManipulation a = new ArrayManipulation();
                        int[] arr = a.initialiseArray(n);
                        int[] res = a.GetLowestNumbers(arr);
                        Console.WriteLine($"First Minimum--> {res[0]}");
                        Console.WriteLine($"Second Minimum--> {res[1]}");
                        Console.WriteLine($"Sum of Array--> {res[2]}");
                        break;
                    }
            }
        }
    }

}


