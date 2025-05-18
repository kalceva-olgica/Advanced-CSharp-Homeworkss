namespace Practice_vol3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = CarsData.Cars;

            // Filter all cars that have origin from Europe.
            var europeanCars = cars.Where(c => c.Origin == "Europe");
            foreach (var car in europeanCars)
                Console.WriteLine(car.Model);
            Console.WriteLine("----------------------------------------");

            // Find all unique cylinder values for cars.
            var uniqueCylinders = cars.Select(c => c.Cylinders).Distinct();
            foreach (var cylindors in uniqueCylinders)
                Console.WriteLine(cylindors);
            Console.WriteLine("----------------------------------------");

            // Select all car names with their model names converted to uppercase.
            var upperCaseModels = cars.Select(c => c.Model.ToUpper());
            foreach (var model in upperCaseModels)
                Console.WriteLine(model);
            Console.WriteLine("----------------------------------------");


            // Check if there are any cars with horsepower greater than 300.
            var anyOver300HP = cars.Any(c => c.HorsePower > 300);
            Console.WriteLine(anyOver300HP);
            Console.WriteLine("----------------------------------------");

            // Find the car with the highest horsepower.
            var carWithMaxHP = cars.OrderByDescending(c => c.HorsePower).FirstOrDefault();
            if (carWithMaxHP != null)
                Console.WriteLine($"{carWithMaxHP.Model} - {carWithMaxHP.HorsePower} horse powerr");
            Console.WriteLine("----------------------------------------");

            // Filter all "Chevrolet" cars and order them by weight in descending order.
            var chevroletCars = cars.Where(c => c.Model.Contains("Chevrolet"))
                                    .OrderByDescending(c => c.Weight);
            foreach (var car in chevroletCars)
                Console.WriteLine($"{car.Model} - {car.Weight}");
            Console.WriteLine("----------------------------------------");

            // Find the car with the longest model name.
            var carWithLongestName = cars.OrderByDescending(c => c.Model.Length).FirstOrDefault();
            if (carWithLongestName != null)
                Console.WriteLine(carWithLongestName.Model);
            Console.WriteLine("----------------------------------------");

            // Group cars by their origin and then order groups by number of cars ascending.
            var carsGroupedByOrigin = cars.GroupBy(c => c.Origin)
                                      .OrderBy(g => g.Count());
            foreach (var group in carsGroupedByOrigin)
                Console.WriteLine($"{group.Key} {group.Count()} cars");
            Console.WriteLine("----------------------------------------");

            //Find the first 5 cars with the highest horsepower.
            var top5HorsePowerCars = cars.OrderByDescending(c => c.HorsePower)
                             .Take(5);
            foreach (var car in top5HorsePowerCars)
                Console.WriteLine($"{car.Model} - {car.HorsePower} HP");
            Console.WriteLine("----------------------------------------");

            //Find the car with the highest acceleration time.
            var carWithMaxAcceleration = cars.OrderByDescending(c => c.AccelerationTime).FirstOrDefault();
            if (carWithMaxAcceleration != null)
                Console.WriteLine($"{carWithMaxAcceleration.Model} - {carWithMaxAcceleration.AccelerationTime}");
            Console.WriteLine("----------------------------------------");

            // Select only the model and horsepower of cars with horsepower > 200.
            var carsOver200HP = cars.Where(c => c.HorsePower > 200)
                                   .Select(c => new { c.Model, c.HorsePower });
            foreach (var car in carsOver200HP)
                Console.WriteLine($"{car.Model} - {car.HorsePower} HP");
            Console.WriteLine("----------------------------------------");

            //Select all unique origins of cars, ordered alphabetically.
            var uniqueOrigins = cars.Select(c => c.Origin).Distinct().OrderBy(origin => origin);
            foreach (var origin in uniqueOrigins)
                Console.WriteLine(origin);
            Console.WriteLine("----------------------------------------");

            //Select all cars with >4 cylinders, ordered by origin and horsepower.
            var carsWithMoreThan4Cylinders = cars.Where(c => c.Cylinders > 4)
                                   .OrderBy(c => c.Origin)
                                   .ThenBy(c => c.HorsePower);
            foreach (var car in carsWithMoreThan4Cylinders)
                Console.WriteLine($"{car.Model} - {car.Origin} - {car.HorsePower} hp");
            Console.WriteLine("----------------------------------------");

            // Filter all cars that have more than 6 Cylinders not including 6 after that Filter all cars that have exactly 4 Cylinders and have HorsePower more then 110.0. Join them in one result.
            var first = cars.Where(c => c.Cylinders > 6);
            var second = cars.Where(c => c.Cylinders == 4 && c.HorsePower > 110.0);
            var combined = first.Concat(second);
            foreach (var car in combined)
                Console.WriteLine($"{car.Model} - {car.Cylinders} - {car.HorsePower} hp");
            Console.WriteLine("----------------------------------------");


            // Filter all cars that have more then 200 HorsePower and Find out how much is the lowest, highest and average Miles per galon for these cars.

            var hpOver200 = cars.Where(c => c.HorsePower > 200);
            var minMPG = hpOver200.Min(c => c.MilesPerGalon);
            var maxMPG = hpOver200.Max(c => c.MilesPerGalon);
            var avgMPG = hpOver200.Average(c => c.MilesPerGalon);
            Console.WriteLine($"Min MPG: {minMPG}, max MPG: {maxMPG}, avg MPG: {avgMPG:F2}"); // ova edvaj ja ukopcav xD
            Console.WriteLine("----------------------------------------");

            // OVA E MOE
            // Find the top 3 cars (NOT US) that have a model name longer than 10 characters, they should be sorted acceleration time ascending, and you need to select only the model and origin

            var myCreativeQuery = cars
                    .Where(c => c.Origin != "US" && c.Model.Length > 10)
                    .OrderBy(c => c.AccelerationTime)
                    .Take(3)
                    .Select(c => new { c.Model, c.Origin });

            foreach (var car in myCreativeQuery)
                Console.WriteLine($"{car.Model} ({car.Origin})");

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("-----------VOL-3----------------");


            //Select the horsepower of US cars with more than 150 horsepower.
            var usCarsOver150HP = cars
                .Where(c => c.Origin == "US" && c.HorsePower > 150)
                .Select(c => c.HorsePower);
           
            foreach (var hp in usCarsOver150HP)
                Console.WriteLine(hp);
            Console.WriteLine("----------------------------------------");

            // Select the weight of European cars with less than 100 horsepower.
            var europeanCarsUnder100HP = cars
                .Where(c => c.Origin == "Europe" && c.HorsePower < 100)
                .Select(c => c.Weight);
           
            foreach (var weight in europeanCarsUnder100HP)
                Console.WriteLine(weight);
            Console.WriteLine("----------------------------------------");

            // Select the origin of Japanese cars that weigh less than 2200.
            var originsOfJapaneseCars = cars
                .Where(c => c.Origin == "Japan" && c.Weight < 2200)
                .Select(c => c.Origin);
          
            foreach (var origin in originsOfJapaneseCars)
                Console.WriteLine(origin);
            Console.WriteLine("----------------------------------------");

            //Select the cylinder count of US cars with exactly 8 cylinders.
            var usCarsWith8Cylinders = cars
                .Where(c => c.Origin == "US" && c.Cylinders == 8)
                .Select(c => c.Cylinders);
        
            foreach (var cyl in usCarsWith8Cylinders)
                Console.WriteLine(cyl);
            Console.WriteLine("----------------------------------------");

            //Select the miles per gallon of cars with more than 25 miles per gallon and acceleration time over 15 seconds.
            var milesPerGallon = cars
                .Where(c => c.MilesPerGalon > 25 && c.AccelerationTime > 15)
                .Select(c => c.MilesPerGalon);
 
            foreach (var miles in milesPerGallon)
                Console.WriteLine(miles);
            Console.WriteLine("----------------------------------------");

            // Get the acceleration time of the last 4-cylinder car with acceleration time less than 15 seconds.
            var lastFast4CylinderAcceleration = cars
                .Where(c => c.Cylinders == 4 && c.AccelerationTime < 15)
                .LastOrDefault()?.AccelerationTime;
          
            Console.WriteLine(lastFast4CylinderAcceleration);
            Console.WriteLine("----------------------------------------");

            // Get the model name of the first car that has 0 horsepower.
            var firstCarWithZeroHp = cars
                .FirstOrDefault(c => c.HorsePower == 0)?.Model;
          
            Console.WriteLine(firstCarWithZeroHp);
            Console.WriteLine("----------------------------------------");

            // Get the weight of the last Japanese car with more than 90 horsepower.
            var lastJapaneseOver90HP = cars
                .Where(c => c.Origin == "Japan" && c.HorsePower > 90)
                .LastOrDefault()?.Weight;
          
            Console.WriteLine(lastJapaneseOver90HP);
            Console.WriteLine("----------------------------------------");

            //Get the horsepower of the first US car that weighs more than 4000 and has fewer than 6 cylinders.
            var hpOfFirstUsCar = cars
                .FirstOrDefault(c => c.Origin == "US" && c.Weight > 4000 && c.Cylinders < 6)?.HorsePower;
          
            Console.WriteLine(hpOfFirstUsCar);
            Console.WriteLine("----------------------------------------");

            //Get the origin of the last car with acceleration time greater than 20 seconds.
            var lastSAcceleratorOrigin = cars
                .Where(c => c.AccelerationTime > 20)
                .LastOrDefault()?.Origin;
      
            Console.WriteLine(lastSAcceleratorOrigin);
        }
    }
}
