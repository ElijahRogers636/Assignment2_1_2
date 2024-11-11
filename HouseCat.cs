using System;

namespace Assignment2_1_2
{
	public class HouseCat : Cat
	{
		public string Location { get; set; }
		public HouseCat(string name, string description, int age, string variation, string location) : base(name, description, age, variation)
        {
			Location = location;
		}

		public void LivingLocation()
		{
			Console.WriteLine("Lives in a House");
		}
	}
}
