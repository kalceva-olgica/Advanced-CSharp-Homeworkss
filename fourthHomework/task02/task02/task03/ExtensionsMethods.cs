namespace task02.task03
{
    public static class ExtensionsMethods
    {
       
            public static void Drive(this Car car)
            {
                Console.WriteLine("The car is driving.");
            }

            public static void Wheelie(this MotorBike bike)
            {
                Console.WriteLine("The motorbike is doing a wheelie");
            }

            public static void Sail(this Boat boat)
            {
                Console.WriteLine("The boat is sailing");
            }

            public static void Fly(this Plane plane)
            {
                Console.WriteLine("The airplane is flying");
            }
        }

    }

