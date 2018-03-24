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
            loginViewModel.ErrorMessage = "";

            if (ModelState.IsValid)
            {

                byte[] data = System.Text.Encoding.ASCII.GetBytes(loginViewModel.Password);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                String hash = System.Text.Encoding.ASCII.GetString(data);


                User passwordValidation = _context.Users.Single(x => x.Name == loginViewModel.Name);

                if (passwordValidation.Password != hash)
                {
                    return Redirect("/Login/Index1");
                }
                return Redirect("/Home");
            }
            return View();
        }
        //TODO#2 Refactor the Index Post controller to display an error when passwords dont match
        public IActionResult Index1()
        {
            return View();
        }
    }
}
