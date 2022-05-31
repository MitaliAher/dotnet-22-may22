using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
    class BaseClass
    {
        public virtual void Show()
        {
            Console.WriteLine(" I'm Coming from base class");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Show()
        {
            Console.WriteLine("i'm coming from derived class");
        }
    }
    class Overiding
    {
        public static void Main1()
        {
            DerivedClass dc = new DerivedClass();
            dc.Show();

            BaseClass b = new BaseClass();
            b.Show();

            b = new DerivedClass();
            b.Show();
        }
    }

}
