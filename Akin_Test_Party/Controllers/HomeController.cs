using Akin_Test_Party.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Akin_Test_Party.Controllers
{
    public class HomeController : Controller
    {
        public static List<VisitorsModel> Visitors = new List<VisitorsModel>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Create(VisitorsModel visitor)
        {
            Visitors.Add(visitor);
            return RedirectToAction(nameof(Create));
        }
        public IActionResult Summary()
        {
            ViewBag.NumberofGuests = Visitors.Count;
            ViewBag.NumberOfFamilyGuests = Visitors.Where(x => x.IsFamily).Count();
            ViewBag.Youngest = Visitors.Min(x => x.Age);
            ViewBag.Oldest = Visitors.Max(x => x.Age);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
