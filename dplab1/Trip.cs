using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dplab1
{
    public class Trip
    {
        public int Id { get; set; }
        public Rider Rider { get; set; }
        public Driver Driver { get; set; }
        public string PickupLocation { get; set; }
        public string DropOffLocation { get; set; }
        public string RideType { get; set; }
        public double Fare { get; set; }
        public string Status { get; set; }

        public Trip(Rider rider, Driver driver, string pickupLocation, string dropoffLocation, string rideType)
        {
            Rider = rider;
            Driver = driver;
            PickupLocation = pickupLocation;
            DropOffLocation = dropoffLocation;
            RideType = rideType;
            Fare = CalculateFare();
            Status = "Requested";
        }

        public void AssignDriver(Driver driver)
        {
            Driver = driver;
            Driver.AcceptRide(this);
            Console.WriteLine($"Driver {Driver.Name} is assigned.");
        }

        public void StartTrip()
        {
            Status = "Started";
            Console.WriteLine($"Trip started from {PickupLocation} to {DropOffLocation}.");
        }

        public void CompleteTrip()
        {
            Status = "Completed";
            Console.WriteLine($"Trip completed.");
            ProcessPayment();
        }

        public double CalculateFare()
        {
            return RideType == "Luxury" ? 100.0 : 50.0;
        }

        public void ProcessPayment()
        {
            Console.WriteLine($"Processing payment of {Fare} using {Rider.PreferredPaymentMethod}.");
        }
    }
}
