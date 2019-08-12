using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string message = "YO BROS WELCOME TO THE INTERNETYO BROS WELCOME TO THE INTERNETYO BROS WELCOME TO THE INTERNETYO BROS WELCOME TO THE INTERNETYO BROS WELCOME TO THE INTERNET";

            return View("Index", message);
        }
        [HttpGet("Numbers")]
        public IActionResult Numbers()
        {

            int[] numarray = new int[]
            {
                1,5,18,21,5636,12,4,7
            };

            return View("Numbers", numarray);
        }
        [HttpGet("User")]
        public IActionResult User()
        {
            User sampleUser = new User("Bobby", "Hill");

            return View(sampleUser);
        }
        [HttpGet("Users")]
        public IActionResult Users(){
            
            List<User> viewModel = new List<User>()
            {
               new User("Bobby", "Hill"),
               new User("Hank", "Hill"),
               new User("Dora", "Explora"),
               new User("Tony", "Hawk"),
               new User("Fred", "Durst"),
            };
            return View(viewModel);
        }

        

    }
}
