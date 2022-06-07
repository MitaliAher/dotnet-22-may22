using System;
using System.Collections;


namespace TrainingAssignments
{
    class Class7
    {
        public static void Main11()
        {
            //ArrayList al = new ArrayList();
            //string str = "Mitali";
            //int n = 25;
            //DateTime d = DateTime.Now;
            //al.Add(str);
            //al.Add(n);
            //al.Add(d);

            //foreach (var item in al)
            //{
            //    Console.WriteLine(item);
            //}

            Hashtable ht = new Hashtable();
            ht.Add("ora", "oracle");
            ht.Add("vb", "vb.Net");
            ht.Add("cs", "cs.net");
            ht.Add("asp", "asp.net");
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }

            Console.WriteLine("*******************************");
            Console.WriteLine();
            //sortedlist
            //it is a class that has the combination of arraylist and hashtable
            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.Net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }


            //stack
            //LIFO
            Console.WriteLine("*******************************");
            Console.WriteLine();

            Stack stk = new Stack();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sql server");
            stk.Pop();

            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*******************************");
            Console.WriteLine();
            //queue
            //FIFO
            Queue q = new Queue();
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
