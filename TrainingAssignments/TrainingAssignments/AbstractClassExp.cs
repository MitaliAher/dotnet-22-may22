using System;
using System.Collections.Generic;
using System.Text;
/* Create a C# program that implements an abstract class Animal that has a Name property of
 * type text and three methods SetName (string name), GetName and Eat. The Eat method will be an abstract method of type void.
  You will also need to create a Dog class that implements the above Animal class and the Eat method that says the dog is Eating.
To test the program ask the user for a dog name and create a new Dog type object from the Main of the program, give the
Dog object a name, and then execute the GetName and Eat methods.*/

namespace TrainingAssignments
{
    abstract class Animal
    {
        private string Name ;
        public void SetName(string name)
        {

           // Console.WriteLine("Enter Name : ");
            //Console.ReadLine();
            Name = name;
        }

        public string GetName()
        {
            
            
            return Name;
        }

        public abstract void Eat();
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine( "Eating");
        }
    }
    class AbstractClassExp
    {
        public static void Main11()
        {
            Dog d = new Dog();
            Console.Write(" Enter Dog Name  : ");
            d.SetName(Console.ReadLine());
            Console.WriteLine(d.GetName());

            d.GetName();
            d.Eat();
        }
    }
}
