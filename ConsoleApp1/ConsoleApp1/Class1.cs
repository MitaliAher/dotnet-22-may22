using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main2(string[] args)
        {
            int i, j;
            /*for (i = 1; i <= 5; i++)
            {

                for (j = 1; j <= i; j++)
                {

                    Console.Write("*");

                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            int n = 8;
                for (i = 1; i <= n; i++)
                {
                 for (j = 1; j <= n; j++)
                 {
                    if (i == 1 || i == n || j==1 || i==j ||  j==n || j == n-i+1)
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        Console.WriteLine();
                    }
                        
                }
              //  Console.WriteLine("");
               // Console.ReadLine();
            }
        }
        
    }
}
