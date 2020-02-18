using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_menager.Entities
{
    public class Flights
    {
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime DateOfTakeOff { get; set; }
        public DateTime DateOfLanding { get; set; }
        public string TypeOfPlane { get; set; }
        public int IdOfPlane { get; set; }
        public string NameOfPilot { get; set; }
        public int CapacityOfPassangers { get; set; }
        public int CapacityOfBussinesClass { get; set; }

    }
}
