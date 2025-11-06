using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


    public class CustomerDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Active()
        {
            return View();
        }

        public IActionResult Upcoming()
        {
            return View();
        }

        public IActionResult Completed()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
