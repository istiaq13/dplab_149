using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dplab1
{
    public class Rider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
        public string PreferredPaymentMethod { get; set; }

        public Rider(int id, string name, string location, string preferredPaymentMethod)
        {
            Id = id;
            Name = name;
            Location = location;
            PreferredPaymentMethod = preferredPaymentMethod;
            Rating = 5.0; // Default rating
        }

        public void RequestRide(Driver driver, string pickupLocation, string dropoffLocation, string rideType)
        {
            Console.WriteLine($"{Name} has requested a {rideType} from {pickupLocation} to {dropoffLocation}.");
            Trip trip = new Trip(this, driver, pickupLocation, dropoffLocation, rideType);
            trip.AssignDriver(driver);
            trip.StartTrip();
        }

        public void RateDriver(Driver driver, double rating)
        {
            driver.Rating = (driver.Rating + rating) / 2;
            Console.WriteLine($"{Name} rated {driver.Name} a {rating}.");
        }

        public void MakePayment(Trip trip)
        {
            trip.ProcessPayment();
        }
    }
}
