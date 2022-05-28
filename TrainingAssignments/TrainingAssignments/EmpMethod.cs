using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
    class Employees
    {
        public string EmpName;
        public int EmpId;
        public string EmpGender;
        public int salary;


        public void GetData()
        {
            
            Console.WriteLine("Enter Employee Details");
            Console.Write("Enter Employee Name : ");
            EmpName = Console.ReadLine();
            Console.Write("Enter Employee ID : ");
            EmpId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Gender : ");
            EmpGender = Console.ReadLine();
            Console.Write("Enter Employee Salary : ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintData()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Employee Details are");
            Console.WriteLine(EmpName);
            Console.WriteLine(EmpId);
            Console.WriteLine(EmpGender);
            Console.WriteLine(salary);
        }
    }
    class EmpMethod
    {
        public static void Main1()
        {
            Employees[] emplist = new Employees[3];

            for (int i = 0; i < emplist.Length; i++)
            {
                Employees ee = new Employees();
                ee.GetData();
                emplist[i] = ee;
            }

            for (int i = 0; i < emplist.Length; i++)
            {
                emplist[i].PrintData();
            }

        }


    }
}

