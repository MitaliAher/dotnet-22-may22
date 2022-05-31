using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{

    class MethodOver
    {
        
            public static void sum()
            {
                int sum = 1 + 2;
                Console.WriteLine(sum);
            }
            public static void sum(int x, int y)
            {
                int sum = x + y;
                Console.WriteLine(sum);
            }
            public static void sum(int a, int b, int c)
            {
                int sum = a + b + c;
                Console.WriteLine(sum);
            }
            public static void sum(string a, string b)
            {
                int sum = Convert.ToInt32(a) + Convert.ToInt32(b);
                Console.WriteLine(sum);
            }
            public static void Main1()
            {
                sum();
                sum(2, 3, 4 );
                sum(5, 6);
                sum("1", "2");
            }
        }
    }


