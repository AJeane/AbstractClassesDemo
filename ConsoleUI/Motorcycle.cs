using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }
        public bool HasSideCart { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle is in drive!");

        }

        public override void DriveVirtial()
        {
            Console.WriteLine($"This{GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive");
        }



    }







}
