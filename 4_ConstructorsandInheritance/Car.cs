using System;

namespace _4_ConstructorsandInheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("car is being initialized. {0}",registrationNumber);
        }
    }
}
