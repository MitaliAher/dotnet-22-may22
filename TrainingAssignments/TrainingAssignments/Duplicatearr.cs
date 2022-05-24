using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
    class Duplicatearr
    {
        public static void Main11(string[] args)
        {
                int[] arr = new int[100];
                int i, j, num, count = 0;

                //Reads size of the array
                Console.WriteLine("Enter size of the array: ");
                num = Convert.ToInt32(Console.ReadLine());

                //Reads elements in array
                Console.WriteLine("Enter elements in the array: ");
                for (i = 0; i < num; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                //Find all duplicate elements in array
                for (i = 0; i < num; i++)
                {
                    for (j = i + 1; j < num; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                        arr[i] = arr[j];

                   
                            count++;
                            break;
                        }
                    }
                }

                Console.WriteLine("\n Total number of duplicate elements found in array:" + count);
                Console.ReadLine();
            }

        }
    }
