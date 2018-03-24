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
    public class SignupController : Controller
    {

        private BeatTheShiftDbContext _context;

        public SignupController(BeatTheShiftDbContext dbContext)
        {
            _context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //TODO#1 Validate that the user isnt trying to sign up with a username already in db
        [HttpPost]
        public IActionResult Index(SignupViewModel signupViewModel)
        {
            if (ModelState.IsValid)
            {
                byte[] data = System.Text.Encoding.ASCII.GetBytes(signupViewModel.Password);
                data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
                String hash = System.Text.Encoding.ASCII.GetString(data);

                User newUser = new User
                {
                    Name = signupViewModel.Name,
                    Password = hash
                };

                _context.Users.Add(newUser);
                _context.SaveChanges();

                return Redirect("/Login");
            }
            return View(signupViewModel);
        }
    }
}
