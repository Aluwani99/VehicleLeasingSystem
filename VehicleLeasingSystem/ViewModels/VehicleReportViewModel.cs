using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleLeasingSystem.ViewModels
{
    public class VehicleReportViewModel
    {
        public string Manufacturer { get; set; }
        public int Total { get; set; }

        public Dictionary<string, int> BySupplier { get; set; }
        public Dictionary<string, int> ByBranch { get; set; }
        public Dictionary<string, int> ByClient { get; set; }
    }

}