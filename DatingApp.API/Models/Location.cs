using System.Collections.Generic;

namespace DatingApp.API.Models
{
    public class Location 
    {
        public int Id {get; set;}
        public decimal Latitude {get; set;}
        public decimal Longitude{get;set;}
        public ICollection<Flight> Flights;
    }
}