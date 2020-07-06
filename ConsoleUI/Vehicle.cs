using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 2019;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Defaut Model";

        public abstract void DriveAbstract(); // stubbed out method - has no implementation
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive."); // implementation
        }

    }
}
