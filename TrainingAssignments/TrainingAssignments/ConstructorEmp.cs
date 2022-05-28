using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
    class Emp
    {
        private string EmpName;
        private int EmpId;
        private string EmpGender;
        private int salary;
        private string CompanyName;

        public Emp()
        {
            CompanyName = "Capgemini";
        }

        ~Emp()
        { 
        
        }


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
            Console.WriteLine(CompanyName);
        }
    }
    class ConstructorEmp
    {
        public static void Main12()
        {
            Emp[] emplist = new Emp[1];

            for (int i = 0; i < emplist.Length; i++)
            {
                Emp ee = new Emp();
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
