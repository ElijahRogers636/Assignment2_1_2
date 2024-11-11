using System;

namespace Assignment2_1_2
{
	public class Pet
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int Age { get; set; }

		public Pet(string name, string description, int age)
		{
			Name = name;
			Description = description;
			Age = age;
		}

		public void Walk(string name)
		{
			Console.WriteLine($"{name} Moves forward");
		}
	}
}
