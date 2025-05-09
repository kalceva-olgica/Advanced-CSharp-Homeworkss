using task02.task03;

namespace task02

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle car = new Car();
            //Vehicle motorBike = new MotorBike();
            //Vehicle boat = new Boat();
            //Vehicle plane = new Plane();

            //car.DisplayInfo();
            //motorBike.DisplayInfo();
            //boat.DisplayInfo();
            //plane.DisplayInfo();


            Car car = new Car();
            MotorBike motorBike = new MotorBike();
            Boat boat = new Boat();
            Plane plane = new Plane();

            car.Drive();          
            motorBike.Wheelie();   
            boat.Sail();           
            plane.Fly();          




        }
    }
}
