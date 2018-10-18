using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Treehouse.FitnessFrog.Shared.Models;
using Treehouse.FitnessFrog.ViewModels;
using Treehouse.FitnessFrog.Shared.Security;
using Microsoft.Owin.Security;

namespace Treehouse.FitnessFrog.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationUserManager _userManager;
        private readonly ApplicationSignInManager _signInManager;
        private readonly IAuthenticationManager _authenticationManager;

        public AccountController(ApplicationUserManager userManager,
                                ApplicationSignInManager signInManager,
                                IAuthenticationManager authenticationManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _authenticationManager = authenticationManager;
        }


        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(AccountRegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new User { UserName = viewModel.Email, Email = viewModel.Email };
            }
            // If the ModelState is valid...

            // Instantiate a User object

            // Create the user

            // If the user was successfully created...

            // Sign-in the user and redirect them to the web app's "Home" page

            // If there were errors...

            // Add model errors
            return View(viewModel);
        }
    }
}