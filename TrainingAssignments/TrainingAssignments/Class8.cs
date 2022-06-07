using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
   class Maths
    {
        public int num1, num2;
        public int Add(int n1, int n2)
        {
        num1= n1+n2;
            num2=num1+n2;

         return 0;
        }
       
    }
    class Class8
    {

        public static void Main()
        {
            Maths m1 = new Maths();
            Maths m2 = new Maths();

            m1.Add(5, 8);
            m2.Add(7, 2);

            Console.WriteLine($"{ m1.num1} { m2.num2}");
            int[] arr1 = new int[5];
            int[,] arr2 = new int[2, 3];
            int[,,] arr3 = new int[4, 2, 3];
            int[][] arr4 = new int[2][];

            Console.WriteLine(arr1.Rank + arr2.Rank + arr3.Rank + arr4.Rank);
            Console.ReadLine();




            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(101);
            lst.Add(102);
            lst.Add(103);
            lst.Add(104);

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "asp.net");
            dct.Add(4, "fs.net");

            foreach (KeyValuePair<int, string> item in dct)
            {
                Console.WriteLine(item.Key + "=========>" + item.Value);
            }

            //sortedlist
            //it is a class that has the combination of arraylist and hashtable
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.Net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (KeyValuePair<string, string> item in sl)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }

            //stack
            //LIFO
            Console.WriteLine("================");
            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sql server");
            stk.Pop();

            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================");
            //queue
            //FIFO
            Queue<string> q = new Queue<string>();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sql server");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

    }
    }

