using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flight_menager.Entities
{
    public class Reservations
    {
        public string FirstName { get; set; }
        public string FamilyName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public int Telephone { get; set; }
        public string Naionality { get; set; }
        public string TypeOfTicket { get; set; }
    }
}
