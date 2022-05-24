using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
    class MatrixAdd
    {
        public static void Main121()
        {

            int[,] array1 = new int[2, 2];
            int[,] array2 = new int[2, 2];
            int[,] array3 = new int[2, 2];

            //Input from arr1
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("Please enter the value for array1[" + row + "," + col + "]: ");
                    array1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Input from arr2
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("Please enter the value for arr2[" + row + "," + col + "]: ");
                    array2[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    array3[row, col] = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        //array3[row, col] = Convert.ToInt32(Console.ReadLine());
                        array3[row, col] += array1[row, k] * array2[k, col];
                        
                    }

                }
            }
            Console.WriteLine("Answer is : ");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    //Console.WriteLine("Answer is : ");
                    Console.Write( array3[row,col] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
