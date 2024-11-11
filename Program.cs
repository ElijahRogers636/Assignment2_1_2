namespace Assignment2_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet1 = new Pet("Kim", "Its a Pet", 14);
            Dog dog1 = new Dog("Matt", "Its a Dog", 5, "Boston Terrier");
            Cat cat1 = new Cat("Tom", "Its a Cat", 7, "Calico");
            HouseCat houseCat1 = new HouseCat("Phil", "Its a house cat", 2, "Tabby", "House");

            pet1.Walk(pet1.Name);
            Console.WriteLine("Name: " + pet1.Name + 
                              "\nDescription: " + pet1.Description + 
                              "\nAge: " + pet1.Age);

            Console.WriteLine();

            // Subclass of pet
            dog1.Bark();
            dog1.Walk(dog1.Name);
            Console.WriteLine("Name: " + dog1.Name + 
                              "\nDescription: " + dog1.Description + 
                              "\nAge: " + dog1.Age + 
                              "\nBreed: " + dog1.Breed);

            Console.WriteLine();

            // Subclass of pet
            cat1.Meow();
            cat1.Walk(cat1.Name);
            Console.WriteLine("Name: " + cat1.Name + 
                              "\nDescription: " + cat1.Description + 
                              "\nAge: " + cat1.Age + 
                              "\nVariation: " + cat1.Variation);

            Console.WriteLine();

            // Subclass of Cat which is a subclass of Pet
            houseCat1.Meow();
            houseCat1.Walk(houseCat1.Name);
            houseCat1.LivingLocation();
            Console.WriteLine("Name: " + houseCat1.Name + 
                                "\nDescription: " + houseCat1.Description + 
                                "\nAge: " + houseCat1.Age + 
                                "\nVariation: " + houseCat1.Variation + 
                                "\nLocation: " + houseCat1.Location);
        }
    }
}
