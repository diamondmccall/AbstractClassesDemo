﻿using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}
		public bool HasASideCart { get; set; } = false;
		public override void DriveAbstract()
        {
            Console.WriteLine($"This motorcycle is in drive");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} is Virtually in drive.");
        }

    }
}

