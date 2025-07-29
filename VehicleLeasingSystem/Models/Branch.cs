using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleLeasingSystem.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}