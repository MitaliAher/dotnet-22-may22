using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingAssignments
{
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);
    }

    public class Car : IVehicle
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            Fuel = fuel;
        }

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Not fuel");
            }
        }

        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
    }
    class InterfaceExp
    {
        public static void Main11(string[] args)
        {
            Car car = new Car(0);
             Console.Write("Enter Fuel : ");
            //int fuel = int.Parse(Console.ReadLine());
            int fuel = Convert.ToInt32(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }
        }
    }
}
