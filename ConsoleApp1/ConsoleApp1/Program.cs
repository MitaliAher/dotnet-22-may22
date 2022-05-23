using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int a = 12;
            //int b = 20;
            //int sum = a+b;
            //Console.Write("sum = ");
            //Console.Write(a + b);



            /*  if (a < 18)
              {
                  Console.WriteLine("Person is not eligible for voting");

              }
              else if (a > 18  && a<=60)
              {
                  Console.WriteLine("Person is eligible for voting");
              }

          else

              Console.WriteLine(" Person  is a Senior citizen");*/

           /* Console.WriteLine(" Enter Choice Code ");
            int choice = Convert.ToInt32(Console.ReadLine());
          //  int choice = 1;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("You Must Enter The Choice Code Between 1 To 7");
                    break;
            }*/

                Console.WriteLine("Enter the action you want to perform");
                Console.WriteLine("1 for Addition");
                Console.WriteLine("2 for Subtraction");
                Console.WriteLine("3 for Multiplication");
                Console.WriteLine("4 for Division");
            Console.WriteLine();

            int Choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Addition is = " + (a+b));
                    break;

                case 2:
                    Console.WriteLine("Substration is = " + (a-b));
                    break;

                case 3:
                    Console.WriteLine("Multiplication is = " + (a*b));
                    break;

                case 4:
                    Console.WriteLine("Division is = " + (a/b));
                    break;

                default:
                        Console.Write("Please Choose a correct code");
                    break;
            }
        }

        }
    }

