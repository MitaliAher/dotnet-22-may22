using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
    class PropertiesInClass
    {
        public PropertiesInClass(double r)
        {
            _radius = r;
        }
        private double _radius;
        private const double _pi = 3.14;
        public double radius
        {
            get
            {
                return _radius;
            }
        }
        public void PrintCircumference()
        {
            Console.WriteLine(2 * _pi * radius);
        }
    }
    class Properties
    {
        public static void Main11()
        {
            PropertiesInClass p = new PropertiesInClass(2);
            Console.WriteLine("Radius is " + p.radius);
            p.PrintCircumference();

        }

    }
}

