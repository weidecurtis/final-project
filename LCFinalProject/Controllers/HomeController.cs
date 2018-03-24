using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LCFinalProject.Models;
using LCFinalProject.Data;
using LCFinalProject.ViewModels;

namespace LCFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private BeatTheShiftDbContext _context;

        public HomeController(BeatTheShiftDbContext dbContext)
        {
            _context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult History()
        {
            return View();
        }

        public IActionResult Projections()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
