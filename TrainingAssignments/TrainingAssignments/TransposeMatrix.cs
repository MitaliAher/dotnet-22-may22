using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
    class TransposeMatrix
    {
        public static void Main9()
        {

            
                int row, col, m, n;
                int[,] arr1 = new int[30, 30];
                int[,] arr2 = new int[30, 30];

                Console.Write("\nEnter the number of rows and columns of the matrix :\n");
                Console.Write("Rows = ");
                m = Convert.ToInt32(Console.ReadLine());

                Console.Write("Columns = ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Set elements in the matrix...\n");
                for (row = 0; row < m; row++)
                {
                    for (col = 0; col < n; col++)
                    {
                        Console.Write("\n [{0}],[{1}] : ", row, col);
                        arr1[row, col] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("\n\nMatrix before Transpose:\n");
                for (row = 0; row < m; row++)
                {
                    Console.Write("\n");
                    for (col = 0; col < n; col++)
                        Console.Write("{0}\t", arr1[row, col]);
                }

                for (row = 0; row < m; row++)
                {
                    for (col = 0; col < n; col++)
                    {

                        arr2[col, row] = arr1[row, col];
                    }
                }

                Console.Write("\n\nMatrix after Transpose: ");
                for (row = 0; row < m; row++)
                {
                    Console.Write("\n");
                    for (col = 0; col < n; col++)
                    {
                        Console.Write("{0}\t", arr2[row, col]);
                    }
                }
                Console.Write("\n\n");
            }
        }
    }
 