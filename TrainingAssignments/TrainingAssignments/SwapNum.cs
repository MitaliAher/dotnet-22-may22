using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
    class SwapNum
    {
        /* //Value Type and Reference Types
         static void Main(string[] args)
         {
             int x = 5, y = 6;
             Console.WriteLine("Before Swapping \na=" + x + "  b=" + y);
             Swap(ref x, ref y);
             Console.WriteLine("After Swapping \na=" + x + "  b=" + y);
         }

         static void Swap(ref int a, ref int b)
         {
             int c;
             c = a;
             a = b;
             b = c;
             Console.WriteLine("In Swap Method \na=" + a + "  b=" + b);
         }*/

        //Value Type and Reference Types

        //out
        static void Main1(string[] args)
        {
            

            int result;
            sample(24, out result);
            Console.WriteLine("Out value \na=" + result);

            //only able to get one value or variable from the function
            int result1 = x12();

            //can recive multipe values from a function.
            int result2, result3, result4;
            x1(out result2, out result3, out result4);
            Console.WriteLine("values are : " + result2 );
            Console.WriteLine("values are : " + result3);
            Console.WriteLine("values are : " + result4);
        }

        

        static void sample(int z, out int s)
        {
            s = z + 1;
        }

        static int x12()
        {
            return 1;
        }

        static void x1(out int s1, out int s2, out int s3)
        {
            s1 = 1;
            s2 = 2;
            s3 = 3;
        }
    }
}
