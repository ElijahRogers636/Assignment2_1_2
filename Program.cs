namespace Assignment2_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Matt", "Its a Dog", 5, "Boston Terrier");
            Cat cat1 = new Cat("Tom", "Its a Cat", 7, "Calico");

            dog1.Bark();
            dog1.Walk(dog1.Name);
            Console.WriteLine("Name: " + dog1.Name + "\nDescription: " + dog1.Description + "\nAge: " + dog1.Age + "\nBreed: " + dog1.Breed);

            Console.WriteLine();

            cat1.Meow();
            cat1.Walk(cat1.Name);
            Console.WriteLine("Name: " + cat1.Name + "\nDescription: " + cat1.Description + "\nAge: " + cat1.Age + "\nVariation: " + cat1.Variation);
        }
    }
}
