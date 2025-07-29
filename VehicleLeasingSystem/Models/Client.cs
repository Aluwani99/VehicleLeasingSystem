using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleLeasingSystem.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }

}