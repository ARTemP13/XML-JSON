using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest06
{
    public class Ship
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int YearBuilt { get; set; }
        public double Speed { get; set; }
        public int CrewCount { get; set; }
    }
    public class Port { 
        public string Name { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
        public int Docks { get; set; }
    }
    public class Passenger { 
        public string FullName { get; set; }
        public string PassengerType { get; set; }
        public DateTime DateofBirth { get; set; }
        public int tickets { get; set; }
        public DateTime DepartureDate { get; set; }

    }

}
