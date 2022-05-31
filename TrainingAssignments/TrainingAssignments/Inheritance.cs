using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
    public class Shape
    {
        protected double length;
        protected double width;
    }

    public class Square : Shape
    {
        public Square(double side)
        {
            length = width = side;
        }

        public void PrintArea()
        {
            Console.WriteLine("Area of a square is : " + (length * width));
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public void PrintArea()
        {
            Console.WriteLine("Area of a Rectange is : " + (length * width));
        }
    }
   
class Inheritance
    {
        public static void Main11()
        {
            
            Rectangle r = new Rectangle(2.5, 5.2);
            r.PrintArea();
            Square s = new Square(2.5);
            s.PrintArea();
        }
    }
}

