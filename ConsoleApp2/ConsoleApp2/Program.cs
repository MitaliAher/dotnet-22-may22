using System;
using ConsoleApp2.Models;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample1Context s1 = new Sample1Context();
            SampleT sampl = new SampleT();
             sampl.Fname = "Mitali Aherrao";
            s1.SampleTs.Add(sampl);
            s1.SaveChanges();

            Console.WriteLine("Hello World!");
        }
    }
}
