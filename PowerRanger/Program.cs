using System;
using System.Collections.Generic;


namespace PowerRanger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a range of number .First enter the small number then the large number");
            int a = int.Parse(Console.ReadLine());//המספר הקטן שבטווח
            int b = int.Parse(Console.ReadLine());//המספר הגדול שבטווח
            Console.WriteLine("Now enter the pow");
            int n = int.Parse(Console.ReadLine());//החזקה
            int power = 1;//המספר שנעלה כל פעם בחזקה ונבדוק האם הוא בטווח
            List<double> nums = new List<double>();
           
            double x=0;
            while (x <= b)
            {
                x = Math.Pow(power, n);
                if(x>=a && x<=b)
                    nums.Add(x);
                power++;
            }
            nums.ForEach(x => Console.WriteLine(x));
            Console.WriteLine($"There is {nums.Count} values for this power");
        }
    }
}
