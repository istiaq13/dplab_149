using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dplab1
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string VehicleType { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
        public bool Availability { get; set; }

        public Driver(int id, string name, string vehicleType, string location)
        {
            Id = id;
            Name = name;
            VehicleType = vehicleType;
            Location = location;
            Rating = 5.0;
            Availability = true;
        }

        public void AcceptRide(Trip trip)
        {
            if (Availability)
            {
                Console.WriteLine($"{Name} has accepted the ride request.");
                Availability = false;
            }
            else
            {
                Console.WriteLine($"{Name} is not available.");
            }
        }

        public void RateRider(Rider rider, double rating)
        {
            rider.Rating = (rider.Rating + rating) / 2;
            Console.WriteLine($"{Name} rated {rider.Name} a {rating}.");
        }

        public void UpdateLocation(string newLocation)
        {
            Location = newLocation;
            Console.WriteLine($"{Name}'s location updated to {newLocation}.");
        }
    }
}
