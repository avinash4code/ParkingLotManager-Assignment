using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotManager
{
    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot myTestParkingLot = new ParkingLot();
            myTestParkingLot.NumOfHatchbacks = 5;
            myTestParkingLot.NumOfSedans = 5;
            myTestParkingLot.NumOfTrucks = 5;

            myTestParkingLot.InitializeParkingLot();

            ParkingSpot spot;
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Sedan });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Sedan });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Sedan });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Sedan });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Sedan });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Sedan });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Sedan });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);


            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Truck });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Truck });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Truck });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Truck });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Truck });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);

            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Hatchback });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Hatchback });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Hatchback });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Hatchback });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
            spot = myTestParkingLot.AssignParkingSpot(new Vehicle() { VehicleSize = Size.Hatchback });
            Console.WriteLine(spot == null ? "No spot available" : "Assigned spot with size: " + spot.SpotSize);
                                   
            Console.Read();
        }
    }
}
