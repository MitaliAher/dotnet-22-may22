using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
    class Array
    {
        public static void Main(string[] args)
        {
            string s;
             string rev = string.Empty;
            
            Console.WriteLine("Enter a String ");
            s=Console.ReadLine();

            for (int i = s.Length - 1; i >= 0; i--)
            { 
                rev += s[i];
            }

            if(s == rev)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not Palindrome");
            }
           // Console.ReadKey();
        }
    }
}
