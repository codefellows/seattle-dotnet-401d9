using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMSCohort9.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CMSCohort9.Pages.Account
{
    public class LogOutModel : PageModel
    {
        private SignInManager<ApplicationUser> _signInManager;

        public LogOutModel(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;

        }

        public async Task<IActionResult> OnPost()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }

    }
}