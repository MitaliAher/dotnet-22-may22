using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{

    class SampleClass
    {
        private int a;
        private int b;
        private string str;

        //default 
        //public SampleClass()
        // {

        // }
        // //parameterized
        // public SampleClass(int _a)
        // {
        //     a = _a;
        // }

        public SampleClass() { }

        //Copy Constructor
       public SampleClass(SampleClass c)
        {
            a = c.a;
            str = c.str;

        }
      
        public void SetValue(int _a)
        {
            a = _a;
        }

        public void SetVal(string _str)
        {
            str = _str;
        }

        public void printValue()
        {
            Console.WriteLine(a);
            Console.WriteLine(str);
        }
    }
    class Class2
    {
        public static void Main1()
        {
            SampleClass S = new SampleClass();
            S.SetValue(20);
            S.SetVal("asdf");
            SampleClass S1 = new SampleClass(S);
            S1.printValue();
        }
    }
}
