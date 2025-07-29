using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleLeasingSystem.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }

}