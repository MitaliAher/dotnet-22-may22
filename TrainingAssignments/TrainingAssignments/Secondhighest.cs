using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
    class Secondhighest
    {
        public static void Main123(string[] args)
        {

            int i, j = 0;
            int l, sl;
            int[] ar = new int[20];
            Console.WriteLine("Enter number of inputs");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input elements in array");
            for (i = 0; i < n; i++)
            {
                Console.Write("Element ", i);
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }

            l = 0;
            for (i = 0; i < n; i++)
            {
                if (l < ar[i])
                {
                    l = ar[i];
                    j = i;
                }


            }

            sl = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    continue;
                }
                else
                {
                    if (sl < ar[i])
                    {
                        sl = ar[i];
                    }
                }
            }

            Console.WriteLine("Second highest number in array is : " + sl);

        }
    }
}
