using System;
using System.Collections.Generic;

namespace ConsecutiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            Console.WriteLine("Enter a list of numbers and press 0 to end");
            int x = int.Parse(Console.ReadLine());
            while(x!=0)
            {
                nums.Add(x);
                x = int.Parse(Console.ReadLine());
            }
            nums.ForEach(x => Console.WriteLine(x));    
            ConsecutiveNumbers(nums);

        }
        public static void ConsecutiveNumbers(List<int> nums)
        {
            int count = 0;
            for(int i= 0; i<nums.Count; i++)
            {
                 for(int j= 0; j<nums.Count; j++)
                {
                    if(nums[i]==nums[j]+1)
                     count++;
                }
            }
            if(count == nums.Count-1 && check(nums)==true)
                Console.WriteLine("The list have consecutive numbers");
            else
                Console.WriteLine("The list have not consecutive numbers");

        }
       public static bool check(List<int>nums)
        {
            nums.Sort();
            for (int i = 0; i < nums.Count; i++)
                if (nums[i] == nums[i + 1])
                    return false;
            return true;
        }
    }
}
