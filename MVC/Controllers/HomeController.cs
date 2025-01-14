﻿using Microsoft.AspNetCore.Mvc;
using MvcCore.Models;
using System.Diagnostics;

namespace MvcCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
         public IActionResult Goto()
        {
            return View();
        }
        public IActionResult GetTat() {
                  return View("Goto"); //// if the file is diiferent in view we should pass the name using parenthesis//
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}