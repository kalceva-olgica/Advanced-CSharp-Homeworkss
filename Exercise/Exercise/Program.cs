namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PetStore<Dog> dogStore = new PetStore<Dog>();
            PetStore<Cat> catStore = new PetStore<Cat>();
            PetStore<Fish> fishStore = new PetStore<Fish>();

            dogStore.AddPet(new Dog("Demon", 4, true, "Salmon"));
            catStore.AddPet(new Cat("Bella", 4, false, 7));
            fishStore.AddPet(new Fish("Nemo", 1, "Orange", "Small"));

            dogStore.BuyPet("Rex");
            catStore.BuyPet("Aurora");
            fishStore.BuyPet("Ria");

            Console.WriteLine("Dog");
            dogStore.PrintPets();

            Console.WriteLine("Cat");
            catStore.PrintPets();

            Console.WriteLine("Fish");
            fishStore.PrintPets();
        }
    }
}
