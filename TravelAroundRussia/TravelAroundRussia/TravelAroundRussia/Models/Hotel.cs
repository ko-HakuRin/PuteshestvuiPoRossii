using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAroundRussia.Models
{
    public class Hotel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int StarCount { get; set; }
        public string CountryName { get; set; }
        public int TourCount { get; set; }
    }
}
