using System;

namespace TrainingAssignments
{
    class Factorial
    {
         static void Main1q(string[] args)
            {
                
                Factorials();
            }

            static void Factorials()
            {
                
                int fact = 1;

            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
                {
                    fact = fact * i;
                }
            Console.WriteLine("Factorial of number is :" + fact);
              //  Console.WriteLine(fact);
                Console.ReadLine();
            }
        }

    }




