using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
    class Class1
    {
        static void Main11(string[] args)
        {
            //var vs dynamic variable

            var x = 1;

            //var y = "Mitali";
            //y = 1;
            dynamic x1 = 2;
            x1 = "Mitali";

            Console.WriteLine(x);
            Console.WriteLine(x1);
        }
    }
}
