﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TDD.Models;

namespace TDD.Controllers
{
    public class HomeController : Controller
    {

        Sum _sum;
        public HomeController()
        {
            _sum =new  Sum();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sum(string numbers)
        {
            return Json(_sum.Execute(numbers));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}