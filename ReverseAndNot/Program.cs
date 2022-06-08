using System;
using System.Collections.Generic;

namespace ReverseAndNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int i= int.Parse(Console.ReadLine());
            string notReverse= i.ToString();
            string reverse = i.ToString();
             reverse = Reverse(reverse);
            Console.WriteLine(reverse+notReverse);
            List<char> list = new List<char>();
           
            
        }
        public static string Reverse(string str)
        { 
            List<char> reverse = new List<char>();
            
          for(int i= str.Length-1; i>=0; i--)
            {
                reverse.Add(str[i]);
               
            }
            string rev = "";
            reverse.ForEach(x => rev += x);


            return rev;
        }
    }
}
