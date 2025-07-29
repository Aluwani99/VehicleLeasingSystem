using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using VehicleLeasingSystem.Models;
using VehicleLeasingSystem.ViewModels;

namespace VehicleLeasingSystem.Controllers
{
    public class HomeController : Controller
    {

        private AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult VehicleReport()
        {
            var vehicles = db.Vehicles
                .Include(v => v.Supplier)
                .Include(v => v.Branch)
                .Include(v => v.Client)
                .Include(v => v.Driver)
                .ToList();

            var report = vehicles
                .GroupBy(v => v.Manufacturer)
                .Select(g => new VehicleReportViewModel
                {
                    Manufacturer = g.Key,
                    Total = g.Count(),

                    BySupplier = g.Select(v => v.Supplier.Name)
                                  .GroupBy(name => name)
                                  .ToDictionary(grp => grp.Key, grp => grp.Count()),

                    ByBranch = g.Select(v => v.Branch.Name)
                                .GroupBy(name => name)
                                .ToDictionary(grp => grp.Key, grp => grp.Count()),

                    ByClient = g.Select(v => v.Client.CompanyName)
                                .GroupBy(name => name)
                                .ToDictionary(grp => grp.Key, grp => grp.Count())
                })
                .ToList();

            return View(report);
        }




    }

}