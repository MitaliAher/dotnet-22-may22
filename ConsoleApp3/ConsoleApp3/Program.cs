using System;
using ConsoleApp3.Models;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter Choice Number : ");
                Console.WriteLine("1.Add Record");
                Console.WriteLine("2.List Record");
                Console.WriteLine("3.Update Record");
                Console.WriteLine("4.Delete Record");
                Console.WriteLine("5.Exit");
                Console.WriteLine("------------------------------------------");

                int ch = Convert.ToInt32(Console.ReadLine());
                Demo1Context dd = new Demo1Context();

                switch (ch)
                {
                    case 1:

                        //Insertion
                        Console.WriteLine();
                        Console.Write(" Enter Name : ");
                        string name = Console.ReadLine();
                        // Demo1Context dd = new Demo1Context();
                        SampleTable tt = new SampleTable();
                        tt.Fname = name;
                        dd.SampleTables.Add(tt);
                        dd.SaveChanges();
                        Console.WriteLine("Record has been added in database  ");


                        break;
                    //Console.WriteLine("Hello World!");
                    case 2:
                        var data = dd.SampleTables;

                        Console.WriteLine();
                        Console.WriteLine("Values from Database : ");
                        foreach (var item in data)
                        {
                            Console.WriteLine(item.Id + " | " + item.Fname);
                        }
                        break;
                    case 3:
                        //How we can Update the value
                        Console.WriteLine();
                        Console.WriteLine(" Enter ID which you Want to Update : ");
                        int InsertItem = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter the new name");
                        var newName = Console.ReadLine();
                        var UpdateObject = dd.SampleTables.Where(x => x.Id == InsertItem).FirstOrDefault();
                        UpdateObject.Fname = newName;
                        dd.SampleTables.Update(UpdateObject);
                        dd.SaveChanges();
                        Console.WriteLine("Record has been Updated  ");

                        break;
                    case 4:
                        //How we can delete the value
                        Console.WriteLine(" Enter ID which you want to Delete :");
                        int DeleteItem = Convert.ToInt32(Console.ReadLine());
                        var DeleteObject = dd.SampleTables.Where(x => x.Id == DeleteItem).FirstOrDefault();
                        dd.SampleTables.Remove(DeleteObject);
                        dd.SaveChanges();
                        Console.WriteLine("Record has been Deleted  ");
                        break;
                    case 5:
                        Console.WriteLine("     Thank You     ");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice ");
                        break;

                        //foreach (var item in data)
                        //{
                        //    Console.WriteLine(item.Id + " | " + item.Fname);
                        //}



                        //foreach (var item in data)
                        //{
                        //    Console.WriteLine(item.Id + " | " + item.Fname);
                        //}
                }

            }
        }
    }
   
}
