using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LCFinalProject.Data;
using LCFinalProject.Models;
using LCFinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LCFinalProject.Controllers
{
    public class LoginController : Controller
    {
        private BeatTheShiftDbContext _context;

        public LoginController(BeatTheShiftDbContext dbContext)
        {
            _context = dbContext;
        }



        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                User passwordValidation = _context.Users.Single(x => x.Name == loginViewModel.Name);

                if (passwordValidation.Password != loginViewModel.Password)
                {
                    return Redirect("/Login/Index1");
                }
                return Redirect("/Home");
            }
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }
    }
}
