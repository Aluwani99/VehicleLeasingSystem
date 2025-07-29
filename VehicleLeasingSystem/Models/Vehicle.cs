using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleLeasingSystem.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public int SupplierId { get; set; }
        public int BranchId { get; set; }
        public int ClientId { get; set; }
        public int DriverId { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Client Client { get; set; }
        public virtual Driver Driver { get; set; }
    }

}