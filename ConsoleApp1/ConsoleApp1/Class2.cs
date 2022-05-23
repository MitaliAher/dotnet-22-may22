using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main(string[] args)
        {
           // int a = ;
            for(int i = 0; i <= 9; i++)
            {
                for(int j = 0; j <= 9; j++)
                {
                    if(i == 0 || i == 9 || j == 0 || j == 9-i+1 || i == j || j == 9)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
