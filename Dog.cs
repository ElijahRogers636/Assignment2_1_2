using System;
namespace Assignment2_1_2
{
	
	public class Dog : Pet
	{
		public string Breed { get; set; }

		public Dog(string name, string description, int age ,string breed) : base(name, description, age)
		{	
			Breed = breed;
		}

		public void Bark()
		{
			Console.WriteLine("Woof");
		}
	}
}
