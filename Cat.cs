using System;
namespace Assignment2_1_2
{
	public class Cat : Pet
	{
        public string Variation { get; set; }

        public Cat(string name, string description, int age, string variation) : base(name, description, age)
		{
			Variation = variation;
		}

		public void Meow()
		{
			Console.WriteLine("Meow");
		}
	}
}
