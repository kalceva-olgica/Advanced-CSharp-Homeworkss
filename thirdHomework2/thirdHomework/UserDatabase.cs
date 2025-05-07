namespace thirdHomework
{
    public static class UserDatabase
    {
        public static List<User> Users = new List<User>
    {
        new User(1, "Sofia", 21),
        new User(2, "Manuela", 44),
        new User(3, "Aneta", 58)
    };

        public static List<User> Search(int? id = null, string name = null, int? age = null)
        // '?' e nullable odnosno toa znaci i da ne stavime id nema da ni izvadi error tuku toa sto ke go stavime toa ke ni vrati
        {
            List<User> result = new List<User>();

            foreach (var user in Users)
            {
                if ((id == null || user.Id == id) &&
                    (name == null || user.Name == name) &&
                    (age == null || user.Age == age))
                {
                    result.Add(user);
                }
            }

            return result;
        }


    }

}

