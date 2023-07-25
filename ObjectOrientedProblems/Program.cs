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
            }
        }
    }

}

