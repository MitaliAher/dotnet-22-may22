using System;

namespace TrainingAssignments
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i<=n; i++)
            {
                for(int j = 1; j<=n-i; j++)
                {
                    Console.Write("");
                }
                for(int k =0; k<=n-i; k++ )
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
            for(int i=1; i<=n-1; i++)
            {
                for(int j=1; j<i+1; j++)
                {
                    Console.Write("");
                }
                for(int k=1; k<=i+1; k++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
