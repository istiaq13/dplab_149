using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dplab1
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Admin(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void ManageDriver(Driver driver)
        {
            Console.WriteLine($"Admin {Name} is managing Driver {driver.Name}.");
            driver.Availability = !driver.Availability;
        }

        public void ViewTripHistory(List<Trip> tripHistory)
        {
            Console.WriteLine($"Admin {Name} is viewing trip history.");
            foreach (var trip in tripHistory)
            {
                Console.WriteLine($"Trip {trip.Id}: {trip.Status}, Fare: {trip.Fare}");
            }
        }

        public void HandleDispute(Rider rider, Driver driver)
        {
            Console.WriteLine($"Admin {Name} is handling dispute between {rider.Name} and {driver.Name}.");
        }
    }
}
