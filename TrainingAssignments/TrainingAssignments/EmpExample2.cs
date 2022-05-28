using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
    class Employee
    {
        public string EmpName;
        public int EmpId;
        public string EmpGender;
        public int salary;
    }
    class EmpExample2
    {
        public static void Main11()
        {
            Employee e = new Employee();

            /* Console.Write("Enter name of employee : ");
             e.EmpName = Console.ReadLine();
             Console.Write("Entet Employee ID : ");
             e.EmpId = Convert.ToInt32( Console.ReadLine());
             Console.Write("Enter gender of employee : ");
             e.EmpGender = Console.ReadLine();
             Console.Write("Enter salary of employee : ");
             e.salary =Convert.ToInt32( Console.ReadLine());*/

            e.EmpName = "Mitali";
            e.EmpId = 101;
            e.EmpGender = "Female";
            e.salary = 2000;

            Console.WriteLine("\n");
            Console.WriteLine("Information of Employee is   ");
            Console.WriteLine("Name : " +e.EmpName);
            Console.WriteLine("ID : " +e.EmpId);
            Console.WriteLine("Gender : " +e.EmpGender);
            Console.WriteLine("Salary : " +e.salary);

        }
    }

    
}
