using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotManager
{
    public class ParkingLot
    {
        private List<ParkingSpot> _listOfSpots;
        public int NumOfHatchbacks { get; set; }
        public int NumOfSedans { get; set; }
        public int NumOfTrucks { get; set; }
        public void InitializeParkingLot()
        {
            _listOfSpots = new List<ParkingSpot>();
            for(int i=0; i<NumOfHatchbacks; i++)
            {
                _listOfSpots.Add(new ParkingSpot() { SpotSize = Size.Hatchback });
            }
            for (int i = 0; i < NumOfSedans; i++)
            {
                _listOfSpots.Add(new ParkingSpot() { SpotSize = Size.Sedan});
            }
            for (int i = 0; i < NumOfTrucks; i++)
            {
                _listOfSpots.Add(new ParkingSpot() { SpotSize = Size.Truck });
            }
        }

        public ParkingSpot AssignParkingSpot(Vehicle vehicle)
        {
            ParkingSpot spot = null;
            switch (vehicle.VehicleSize)
            {
                case Size.Hatchback:
                    spot = _listOfSpots.FirstOrDefault(e => e.SpotSize == Size.Hatchback && e.OccupiedVehicle == null);
                    if (spot != null)
                    {
                        spot.OccupiedVehicle = vehicle;
                    }
                    else
                    {
                        spot = _listOfSpots.FirstOrDefault(e => e.SpotSize == Size.Sedan && e.OccupiedVehicle == null);
                        if (spot != null)
                        {
                            spot.OccupiedVehicle = vehicle;
                        }
                        else
                        {
                            spot = _listOfSpots.FirstOrDefault(e => e.SpotSize == Size.Truck && e.OccupiedVehicle == null);
                            if (spot != null)
                            {
                                spot.OccupiedVehicle = vehicle;
                            }
                            else
                            {
                                return spot;
                            }
                        }
                    }
                    break;
                case Size.Sedan:
                    spot = _listOfSpots.FirstOrDefault(e => e.SpotSize == Size.Sedan && e.OccupiedVehicle == null);
                    if (spot != null)
                    {
                        spot.OccupiedVehicle = vehicle;
                    }
                    else
                    {
                        spot = _listOfSpots.FirstOrDefault(e => e.SpotSize == Size.Truck && e.OccupiedVehicle == null);
                        if (spot != null)
                        {
                            spot.OccupiedVehicle = vehicle;
                        }
                        else
                        {
                            return spot;
                        }
                    }
                    break;
                case Size.Truck:
                    spot = _listOfSpots.FirstOrDefault(e => e.SpotSize == Size.Truck && e.OccupiedVehicle == null);
                    if (spot != null)
                    {
                        spot.OccupiedVehicle = vehicle;
                    }
                    else
                    {
                        return spot;
                    }
                    break;
                default:
                    return spot;                    
            }
            return spot;
        }

    }
}
