namespace Exercise
{
    public class PetStore<T> where T : Pet
    {
       private List<T> listOfPets = new List<T>();

        public void AddPet(T pet)
        {
            listOfPets.Add(pet);
        }

        public void PrintPets()
        {
            if (listOfPets.Count == 0)
            {
                Console.WriteLine("We do not have pets in our store");
            }

            foreach (var pet in listOfPets)
            {
                pet.PrintInfo();
            }
        }

        public void BuyPet(string name) // ovaa metoda ne bev najsigurna kako da ja napisam probav nesto ne znam dali e tocno
        {
            T pet = listOfPets.FirstOrDefault(p => p.Name.Equals(name));

            if (pet != null)
            {
                listOfPets.Remove(pet);
                Console.WriteLine($"You have bought {pet.Type} by namee {pet.Name}.");
            }
        }


    }
}
